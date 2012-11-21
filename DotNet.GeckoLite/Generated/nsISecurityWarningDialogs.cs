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
// Generated by IDLImporter from file nsISecurityWarningDialogs.idl
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
	
	
	/// <summary>
    /// Functions that display warnings for transitions between secure
    /// and insecure pages, posts to insecure servers etc.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1c399d06-1dd2-11b2-bc58-c87cbcacdb78")]
	public interface nsISecurityWarningDialogs
	{
		
		/// <summary>
        /// Inform the user that a transition
        /// from an insecure page
        /// to a secure page
        /// is happening.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user confirms to continue
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmEnteringSecure([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
		
		/// <summary>
        /// Inform the user that a transition
        /// from an insecure page
        /// or from a secure page
        /// to a weak security page
        /// is happening.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user confirms to continue
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmEnteringWeak([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
		
		/// <summary>
        /// Inform the user that a transition
        /// from a secure page
        /// to an insecure page
        /// is happening.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user confirms to continue
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmLeavingSecure([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
		
		/// <summary>
        /// Inform the user the currently displayed page
        /// contains some secure and some insecure page components.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user decides to show insecure objects.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmMixedMode([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
		
		/// <summary>
        /// Inform the user that information is being submitted
        /// to an insecure page.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user confirms to submit.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmPostToInsecure([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
		
		/// <summary>
        /// Inform the user: Although the currently displayed
        /// page was loaded using a secure connection, and the UI probably
        /// currently indicates a secure page,
        /// that information is being submitted to an insecure page.
        ///
        /// @param ctx A user interface context.
        ///
        /// @return true if the user confirms to submit.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmPostToInsecureFromSecure([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);
	}
}