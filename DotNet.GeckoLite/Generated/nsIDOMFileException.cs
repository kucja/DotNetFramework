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
// Generated by IDLImporter from file nsIDOMFileException.idl
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
	
	
	/// <summary>nsIDOMFileException </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b52356e1-45c5-4d61-b61a-fb9bd91690e1")]
	public interface nsIDOMFileException
	{
		
		/// <summary>Member GetCodeAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetCodeAttribute();
	}
	
	/// <summary>nsIDOMFileExceptionConsts </summary>
	public class nsIDOMFileExceptionConsts
	{
		
		// 
		public const ulong NOT_FOUND_ERR = 1;
		
		// 
		public const ulong SECURITY_ERR = 2;
		
		// 
		public const ulong ABORT_ERR = 3;
		
		// 
		public const ulong NOT_READABLE_ERR = 4;
		
		// 
		public const ulong ENCODING_ERR = 5;
	}
}