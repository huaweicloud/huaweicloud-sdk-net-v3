using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RefererRsp 
    {

        /// <summary>
        /// Referer类型。取值：0代表不设置Referer过滤；1代表黑名单；2代表白名单。默认取值为0。
        /// </summary>
        [JsonProperty("referer_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefererType { get; set; }

        /// <summary>
        /// ：配置的referer地址。
        /// </summary>
        [JsonProperty("referer_list", NullValueHandling = NullValueHandling.Ignore)]
        public string RefererList { get; set; }

        /// <summary>
        /// 是否包含空Referer。如果是黑名单并开启该选项，则表示无referer不允许访问。如果是白名单并开启该选项，则表示无referer允许访问。默认不包含,true：包含，false：不包含。
        /// </summary>
        [JsonProperty("include_empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEmpty { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefererRsp {\n");
            sb.Append("  refererType: ").Append(RefererType).Append("\n");
            sb.Append("  refererList: ").Append(RefererList).Append("\n");
            sb.Append("  includeEmpty: ").Append(IncludeEmpty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefererRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefererRsp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefererType == input.RefererType ||
                    (this.RefererType != null &&
                    this.RefererType.Equals(input.RefererType))
                ) && 
                (
                    this.RefererList == input.RefererList ||
                    (this.RefererList != null &&
                    this.RefererList.Equals(input.RefererList))
                ) && 
                (
                    this.IncludeEmpty == input.IncludeEmpty ||
                    (this.IncludeEmpty != null &&
                    this.IncludeEmpty.Equals(input.IncludeEmpty))
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
                if (this.RefererType != null)
                    hashCode = hashCode * 59 + this.RefererType.GetHashCode();
                if (this.RefererList != null)
                    hashCode = hashCode * 59 + this.RefererList.GetHashCode();
                if (this.IncludeEmpty != null)
                    hashCode = hashCode * 59 + this.IncludeEmpty.GetHashCode();
                return hashCode;
            }
        }
    }
}
