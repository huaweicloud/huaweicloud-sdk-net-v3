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
    /// 业务共享配置
    /// </summary>
    public class ServiceSharedConfig 
    {

        /// <summary>
        /// 开启共享配置
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 可选的共享租户列表
        /// </summary>
        [JsonProperty("optional_project_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OptionalProjectIds { get; set; }

        /// <summary>
        /// 共享免审核
        /// </summary>
        [JsonProperty("no_need_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoNeedReview { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceSharedConfig {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  optionalProjectIds: ").Append(OptionalProjectIds).Append("\n");
            sb.Append("  noNeedReview: ").Append(NoNeedReview).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceSharedConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceSharedConfig input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.OptionalProjectIds != input.OptionalProjectIds || (this.OptionalProjectIds != null && input.OptionalProjectIds != null && !this.OptionalProjectIds.SequenceEqual(input.OptionalProjectIds))) return false;
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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.OptionalProjectIds != null) hashCode = hashCode * 59 + this.OptionalProjectIds.GetHashCode();
                if (this.NoNeedReview != null) hashCode = hashCode * 59 + this.NoNeedReview.GetHashCode();
                return hashCode;
            }
        }
    }
}
