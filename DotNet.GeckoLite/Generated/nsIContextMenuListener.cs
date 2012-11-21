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
// Generated by IDLImporter from file nsIContextMenuListener.idl
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
    /// An optional interface for embedding clients wishing to receive
    /// notifications for context menu events (e.g. generated by
    /// a user right-mouse clicking on a link). The embedder implements
    /// this interface on the web browser chrome object associated
    /// with the window that notifications are required for. When a context
    /// menu event, the browser will call this interface if present.
    ///
    /// @see nsIDOMNode
    /// @see nsIDOMEvent
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3478b6b0-3875-11d4-94ef-0020183bf181")]
	public interface nsIContextMenuListener
	{
		
		/// <summary>
        /// Called when the browser receives a context menu event (e.g. user is right-mouse
        /// clicking somewhere on the document). The combination of flags, event and node
        /// provided in the call indicate where and what was clicked on.
        ///
        /// The following table describes what context flags and node combinations are
        /// possible.
        ///
        /// <TABLE>
        /// <TR><TD><B>aContextFlag</B></TD><TD>aNode</TD></TR>
        /// <TR><TD>CONTEXT_LINK</TD><TD>&lt;A&gt;</TD></TR>
        /// <TR><TD>CONTEXT_IMAGE</TD><TD>&lt;IMG&gt;</TD></TR>
        /// <TR><TD>CONTEXT_IMAGE | CONTEXT_LINK</TD><TD>&lt;IMG&gt;
        /// with an &lt;A&gt; as an ancestor</TD></TR>
        /// <TR><TD>CONTEXT_INPUT</TD><TD>&lt;INPUT&gt;</TD></TR>
        /// <TR><TD>CONTEXT_TEXT</TD><TD>&lt;TEXTAREA&gt;</TD></TR>
        /// <TR><TD>CONTEXT_DOCUMENT</TD><TD>&lt;HTML&gt;</TD></TR>
        /// </TABLE>
        ///
        /// @param aContextFlags Flags indicating the kind of context.
        /// @param aEvent The DOM context menu event.
        /// @param aNode The DOM node most relevant to the context.
        ///
        /// @return <CODE>NS_OK</CODE> always.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowContextMenu(uint aContextFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
	}
	
	/// <summary>nsIContextMenuListenerConsts </summary>
	public class nsIContextMenuListenerConsts
	{
		
		// <summary>
        //Flag. No context. </summary>
		public const ulong CONTEXT_NONE = 0;
		
		// <summary>
        //Flag. Context is a link element. </summary>
		public const ulong CONTEXT_LINK = 1;
		
		// <summary>
        //Flag. Context is an image element. </summary>
		public const ulong CONTEXT_IMAGE = 2;
		
		// <summary>
        //Flag. Context is the whole document. </summary>
		public const ulong CONTEXT_DOCUMENT = 4;
		
		// <summary>
        //Flag. Context is a text area element. </summary>
		public const ulong CONTEXT_TEXT = 8;
		
		// <summary>
        //Flag. Context is an input element. </summary>
		public const ulong CONTEXT_INPUT = 16;
	}
}