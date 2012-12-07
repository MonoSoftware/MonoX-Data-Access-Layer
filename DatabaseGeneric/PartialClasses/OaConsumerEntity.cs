using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetOpenAuth.OAuth.ChannelElements;
using MonoSoftware.Core;
using DotNetOpenAuth.OAuth;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class OaConsumerEntity : IConsumerDescription
    {

        #region IConsumerDescription Members

        public Uri Callback
        {
            get { return String.IsNullOrEmpty(this.CallbackUrl) ? null : new Uri(this.CallbackUrl); }
        }

        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate
        {
            get { return this.CertificateRaw != null ? new System.Security.Cryptography.X509Certificates.X509Certificate2(this.CertificateRaw) : null; }
        }

        public string Key
        {
            get { return ShortGuid.Encode(this.Id); }
        }

        public VerificationCodeFormat VerificationCodeFormat
        {
            get 
            {
                return (VerificationCodeFormat)Enum.Parse(typeof(VerificationCodeFormat), this.VerificationCodeFormatValue.ToString());
            }
        }

        #endregion
    }
}
