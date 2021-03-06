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
// Generated by IDLImporter from file nsIPrincipal.idl
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
    ///Defines the abstract interface for a principal. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8c4c89a-d726-421b-8415-3e34b241175b")]
	public interface nsIPrincipal : nsISerializable
	{
		
		/// <summary>
        /// Initialize the object implementing nsISerializable, which must have
        /// been freshly constructed via CreateInstance.  All data members that
        /// can't be set to default values must have been serialized by write,
        /// and should be read from aInputStream in the same order by this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);
		
		/// <summary>
        /// Serialize the object implementing nsISerializable to aOutputStream, by
        /// writing each data member that must be recovered later to reconstitute
        /// a working replica of this object, in a canonical member and byte order,
        /// to aOutputStream.
        ///
        /// NB: a class that implements nsISerializable *must* also implement
        /// nsIClassInfo, in particular nsIClassInfo::GetClassID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);
		
		/// <summary>
        /// Returns the security preferences associated with this principal.
        /// prefBranch will be set to the pref branch to which these preferences
        /// pertain.  id is a pseudo-unique identifier, pertaining to either the
        /// fingerprint or the origin.  subjectName is a name that identifies the
        /// entity this principal represents (may be empty).  grantedList and
        /// deniedList are space-separated lists of capabilities which were
        /// explicitly granted or denied by a pref.  isTrusted is a boolean that
        /// indicates whether this is a codebaseTrusted certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPreferences([MarshalAs(UnmanagedType.LPStr)] ref string prefBranch, [MarshalAs(UnmanagedType.LPStr)] ref string id, [MarshalAs(UnmanagedType.LPStr)] ref string subjectName, [MarshalAs(UnmanagedType.LPStr)] ref string grantedList, [MarshalAs(UnmanagedType.LPStr)] ref string deniedList, [MarshalAs(UnmanagedType.U1)] ref bool isTrusted);
		
		/// <summary>
        /// Returns whether the other principal is equivalent to this principal.
        /// Principals are considered equal if they are the same principal,
        /// they have the same origin, or have the same certificate fingerprint ID
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Like equals, but doesn't take document.domain changes into account.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EqualsIgnoringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Returns a hash value for the principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHashValueAttribute();
		
		/// <summary>
        /// method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSecurityPolicyAttribute();
		
		/// <summary>
        /// method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityPolicyAttribute(System.IntPtr aSecurityPolicy);
		
		/// <summary>
        /// messes with it?  Is that OK?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short CanEnableCapability([MarshalAs(UnmanagedType.LPStr)] string capability);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanEnableCapability([MarshalAs(UnmanagedType.LPStr)] string capability, short canEnable);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCapabilityEnabled([MarshalAs(UnmanagedType.LPStr)] string capability, System.IntPtr annotation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableCapability([MarshalAs(UnmanagedType.LPStr)] string capability, ref System.IntPtr annotation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevertCapability([MarshalAs(UnmanagedType.LPStr)] string capability, ref System.IntPtr annotation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableCapability([MarshalAs(UnmanagedType.LPStr)] string capability, ref System.IntPtr annotation);
		
		/// <summary>
        /// The codebase URI to which this principal pertains.  This is
        /// generally the document URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The domain URI to which this principal pertains.
        /// This is congruent with HTMLDocument.domain, and may be null.
        /// Setting this has no effect on the URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDomainAttribute();
		
		/// <summary>
        /// The domain URI to which this principal pertains.
        /// This is congruent with HTMLDocument.domain, and may be null.
        /// Setting this has no effect on the URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomainAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);
		
		/// <summary>
        /// with a chrome URI.  All of chrome should probably be the same.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetOriginAttribute();
		
		/// <summary>
        /// Whether this principal is associated with a certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasCertificateAttribute();
		
		/// <summary>
        /// consider using something else for this....
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFingerprint);
		
		/// <summary>
        /// The pretty name for the certificate.  This sort of (but not really)
        /// identifies the subject of the certificate (the entity that stands behind
        /// the certificate).  Note that this may be empty; prefer to get the
        /// certificate itself and get this information from it, since that may
        /// provide more information.
        ///
        /// Throws if there is no certificate associated with this principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrettyNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrettyName);
		
		/// <summary>
        /// Returns whether the other principal is equal to or weaker than this
        /// principal.  Principals are equal if they are the same object, they
        /// have the same origin, or they have the same certificate ID.
        ///
        /// Thus a principal always subsumes itself.
        ///
        /// The system principal subsumes itself and all other principals.
        ///
        /// A null principal (corresponding to an unknown, hence assumed minimally
        /// privileged, security context) is not equal to any other principal
        /// (including other null principals), and therefore does not subsume
        /// anything but itself.
        ///
        /// Both codebase and certificate principals are subsumed by the system
        /// principal, but no codebase or certificate principal yet subsumes any
        /// other codebase or certificate principal.  This may change in a future
        /// release; note that nsIPrincipal is unfrozen, not slated to be frozen.
        ///
        /// XXXbz except see bug 147145!
        ///
        /// Note for the future: Perhaps we should consider a certificate principal
        /// for a given URI subsuming a codebase principal for the same URI?  Not
        /// sure what the immediate benefit would be, but I think the setup could
        /// make some code (e.g. MaybeDowngradeToCodebase) clearer.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Subsumes([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Same as the previous method, subsumes(), but for codebase principals
        /// ignores changes to document.domain.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SubsumesIgnoringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);
		
		/// <summary>
        /// Checks whether this principal is allowed to load the network resource
        /// located at the given URI under the same-origin policy. This means that
        /// codebase principals are only allowed to load resources from the same
        /// domain, the system principal is allowed to load anything, and null
        /// principals are not allowed to load anything.
        ///
        /// If the load is allowed this function does nothing. If the load is not
        /// allowed the function throws NS_ERROR_DOM_BAD_URI.
        ///
        /// NOTE: Other policies might override this, such as the Access-Control
        /// specification.
        /// NOTE: The 'domain' attribute has no effect on the behaviour of this
        /// function.
        ///
        ///
        /// @param uri    The URI about to be loaded.
        /// @param report If true, will report a warning to the console service
        /// if the load is not allowed.
        /// @throws NS_ERROR_DOM_BAD_URI if the load is not allowed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckMayLoad([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.U1)] bool report);
		
		/// <summary>
        /// The subject name for the certificate.  This actually identifies the
        /// subject of the certificate.  This may well not be a string that would
        /// mean much to a typical user on its own (e.g. it may have a number of
        /// different names all concatenated together with some information on what
        /// they mean in between).
        ///
        /// Throws if there is no certificate associated with this principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSubjectName);
		
		/// <summary>
        /// The certificate associated with this principal, if any.  If there isn't
        /// one, this will return null.  Getting this attribute never throws.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCertificateAttribute();
		
		/// <summary>
        /// A Content Security Policy associated with this principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetCspAttribute();
		
		/// <summary>
        /// A Content Security Policy associated with this principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCspAttribute(System.IntPtr aCsp);
	}
	
	/// <summary>nsIPrincipalConsts </summary>
	public class nsIPrincipalConsts
	{
		
		// <summary>
        // Values of capabilities for each principal. Order is
        // significant: if an operation is performed on a set
        // of capabilities, the minimum is computed.
        // </summary>
		public const int ENABLE_DENIED = 1;
		
		// 
		public const int ENABLE_UNKNOWN = 2;
		
		// 
		public const int ENABLE_WITH_USER_PERMISSION = 3;
		
		// 
		public const int ENABLE_GRANTED = 4;
	}
}
