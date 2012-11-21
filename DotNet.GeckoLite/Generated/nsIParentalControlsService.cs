// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIParentalControlsService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIParentalControlsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("871cf229-2b21-4f04-b24d-e08061f14815")]
	public interface nsIParentalControlsService
	{
		
		/// <summary>
        /// @returns true if the current user account has parental controls
        /// restrictions enabled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetParentalControlsEnabledAttribute();
		
		/// <summary>
        /// @returns true if the current user account parental controls
        /// restrictions include the blocking of all file downloads.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBlockFileDownloadsEnabledAttribute();
		
		/// <summary>
        /// Request that blocked URI(s) be allowed through parental
        /// control filters. Returns true if the URI was successfully
        /// overriden. Note, may block while native UI is shown.
        ///
        /// @param aTarget(s)          URI to be overridden. In the case of
        /// multiple URI, the first URI in the array
        /// should be the root URI of the site.
        /// @param window              Window that generates the event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool RequestURIOverride([MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>Member RequestURIOverrides </summary>
		/// <param name='aTargets'> </param>
		/// <param name='aWindowContext'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool RequestURIOverrides([MarshalAs(UnmanagedType.Interface)] nsIArray aTargets, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>
        /// @returns true if the current user account has parental controls
        /// logging enabled. If true, applications should log relevent events
        /// using 'log'.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoggingEnabledAttribute();
		
		/// <summary>
        /// Log an application specific parental controls
        /// event.
        ///
        /// @param aEntryType       Constant defining the type of event.
        /// @param aFlag            A flag indicating if the subject content
        /// was blocked.
        /// @param aSource          The URI source of the subject content.
        /// @param aTarget          The location the content was saved to if
        /// no blocking occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Log(short aEntryType, [MarshalAs(UnmanagedType.U1)] bool aFlag, [MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIFile aTarget);
	}
	
	/// <summary>nsIParentalControlsServiceConsts </summary>
	public class nsIParentalControlsServiceConsts
	{
		
		// <summary>
        // Log entry types. Additional types can be defined and implemented
        // as needed. Other possible event types might include email events,
        // media related events, and IM events.
        // </summary>
		public const int ePCLog_URIVisit = 1;
		
		// <summary>
        //Web content </summary>
		public const int ePCLog_FileDownload = 2;
	}
}