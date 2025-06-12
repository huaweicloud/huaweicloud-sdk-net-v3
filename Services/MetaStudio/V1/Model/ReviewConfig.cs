using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 内容审核配置
    /// </summary>
    public class ReviewConfig 
    {

        /// <summary>
        /// 免审核。 目前仅白名单用户可使用此参数，非白名单用户跟随系统策略审核。
        /// </summary>
        [JsonProperty("no_need_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoNeedReview { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewConfig {\n");
            sb.Append("  noNeedReview: ").Append(NoNeedReview).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewConfig input)
        {
            if (input == null) return false;
            if (this.NoNeedReview != input.NoNeedReview || (this.NoNeedReview != null && !this.NoNeedReview.Equals(input.NoNeedReview))) return false;

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
                if (this.NoNeedReview != null) hashCode = hashCode * 59 + this.NoNeedReview.GetHashCode();
                return hashCode;
            }
        }
    }
}
