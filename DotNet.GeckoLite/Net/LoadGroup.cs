using System.Collections.Generic;

namespace Gecko.Net
{
	public class LoadGroup
		:Request
	{
		internal nsILoadGroup _loadGroup;

		internal LoadGroup(nsILoadGroup loadGroup)
			:base(loadGroup)
		{
			_loadGroup = loadGroup;
		}

		public nsIRequestObserver GroupObserver
		{
			get { return _loadGroup.GetGroupObserverAttribute(); }
			set { _loadGroup.SetGroupObserverAttribute( value ); }
		}

		public Request DefaultLoadRequest
		{
			get{return new Request( _loadGroup.GetDefaultLoadRequestAttribute() );}
			set{_loadGroup.SetDefaultLoadRequestAttribute( value._request );}
		}

		public void AddRequest(Request request,Interop.nsSupports aContext)
		{
			_loadGroup.AddRequest( request._request, aContext._nsISupports );
		}

		public void RemoveRequest(Request request, Interop.nsSupports aContext, int aStatus)
		{
			_loadGroup.RemoveRequest(request._request, aContext._nsISupports, aStatus);
		}

		public IEnumerable<Request> Requests
		{
			get
			{
				return new Collections.GeckoEnumerableCollection<Request, nsIRequest>( _loadGroup.GetRequestsAttribute,
				                                                                       x => new Request( x ) );
			}
		}


		public uint ActiveCount
		{
			get { return _loadGroup.GetActiveCountAttribute(); }
		}

		public nsIInterfaceRequestor NotificationCallbacks
		{
			get { return _loadGroup.GetNotificationCallbacksAttribute(); }
			set{_loadGroup.SetNotificationCallbacksAttribute( value );}
		}
	}
}