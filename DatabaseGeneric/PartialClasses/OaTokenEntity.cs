using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetOpenAuth.OAuth.ChannelElements;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class OaTokenEntity : IServiceProviderRequestToken, IServiceProviderAccessToken
    {
        #region IServiceProviderRequestToken Members

        public Uri Callback
        {
            get
            {
                return String.IsNullOrEmpty(this.CallbackUrl) ? this.OaConsumer.Callback : new Uri(this.CallbackUrl);
            }
            set
            {
                this.CallbackUrl = value != null ? value.ToString() : null;
            }
        }

        public string ConsumerKey
        {
            get { return this.OaConsumer.Key; }
        }

        public Version ConsumerVersion
        {
            get
            {
                return this.OaConsumer.Version != null ? new Version(this.OaConsumer.Version) : null;
            }
            set
            {
                this.OaConsumer.Version = value.ToString();
            }
        }

        public DateTime CreatedOn
        {
            get { return this.CreatedOnUtc.ToLocalTime(); }
        }

        #endregion

        #region IServiceProviderAccessToken Members

        public string[] Roles
        {
            get { return new string[0]; }
        }

        public string Username
        {
            get { return this.AspnetUsers != null ? this.AspnetUsers.UserName : null; }
        }
        #endregion

        public TokenType TokenType
        {
            get { return this.IsAccess ? TokenType.AccessToken : TokenType.RequestToken; }
        }
    }
}
