using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 更新辅助认证应用对象列表。
    /// </summary>
    public class AssistAuthApplyObjectsRequest 
    {

        /// <summary>
        /// 需要新增的应用对象。
        /// </summary>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyObjects> Add { get; set; }

        /// <summary>
        /// 要移除的应用对象。
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyObjects> Delete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistAuthApplyObjectsRequest {\n");
            sb.Append("  add: ").Append(Add).Append("\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssistAuthApplyObjectsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssistAuthApplyObjectsRequest input)
        {
            if (input == null) return false;
            if (this.Add != input.Add || (this.Add != null && input.Add != null && !this.Add.SequenceEqual(input.Add))) return false;
            if (this.Delete != input.Delete || (this.Delete != null && input.Delete != null && !this.Delete.SequenceEqual(input.Delete))) return false;

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
                if (this.Add != null) hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                return hashCode;
            }
        }
    }
}
