using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetVisionActiveCodeResponse : SdkResponse
    {

        /// <summary>
        /// 激活码。
        /// </summary>
        [JsonProperty("activeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetVisionActiveCodeResponse {\n");
            sb.Append("  activeCode: ").Append(ActiveCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetVisionActiveCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetVisionActiveCodeResponse input)
        {
            if (input == null) return false;
            if (this.ActiveCode != input.ActiveCode || (this.ActiveCode != null && !this.ActiveCode.Equals(input.ActiveCode))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ActiveCode != null) hashCode = hashCode * 59 + this.ActiveCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
