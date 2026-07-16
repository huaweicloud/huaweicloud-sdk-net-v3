using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// workflow main service auth request
    /// </summary>
    public class WorkflowMainServiceAuthReq 
    {

        /// <summary>
        /// 在线服务ID。
        /// </summary>
        [JsonProperty("main_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MainServiceId { get; set; }

        /// <summary>
        /// Gallery资产ID。
        /// </summary>
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowConsume Consume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowMainServiceAuthReq {\n");
            sb.Append("  mainServiceId: ").Append(MainServiceId).Append("\n");
            sb.Append("  contentId: ").Append(ContentId).Append("\n");
            sb.Append("  consume: ").Append(Consume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowMainServiceAuthReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowMainServiceAuthReq input)
        {
            if (input == null) return false;
            if (this.MainServiceId != input.MainServiceId || (this.MainServiceId != null && !this.MainServiceId.Equals(input.MainServiceId))) return false;
            if (this.ContentId != input.ContentId || (this.ContentId != null && !this.ContentId.Equals(input.ContentId))) return false;
            if (this.Consume != input.Consume || (this.Consume != null && !this.Consume.Equals(input.Consume))) return false;

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
                if (this.MainServiceId != null) hashCode = hashCode * 59 + this.MainServiceId.GetHashCode();
                if (this.ContentId != null) hashCode = hashCode * 59 + this.ContentId.GetHashCode();
                if (this.Consume != null) hashCode = hashCode * 59 + this.Consume.GetHashCode();
                return hashCode;
            }
        }
    }
}
