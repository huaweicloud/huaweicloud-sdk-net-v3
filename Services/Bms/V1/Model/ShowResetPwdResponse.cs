using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowResetPwdResponse : SdkResponse
    {

        /// <summary>
        /// 是否支持重置密码。True：支持一键重置密码。False：不支持一键重置密码
        /// </summary>
        [JsonProperty("resetpwd_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResetpwdFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResetPwdResponse {\n");
            sb.Append("  resetpwdFlag: ").Append(ResetpwdFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResetPwdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResetPwdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResetpwdFlag == input.ResetpwdFlag ||
                    (this.ResetpwdFlag != null &&
                    this.ResetpwdFlag.Equals(input.ResetpwdFlag))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResetpwdFlag != null)
                    hashCode = hashCode * 59 + this.ResetpwdFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
