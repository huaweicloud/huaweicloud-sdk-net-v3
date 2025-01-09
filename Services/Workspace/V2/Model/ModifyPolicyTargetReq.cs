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
    /// 
    /// </summary>
    public class ModifyPolicyTargetReq 
    {

        /// <summary>
        /// 添加应用。
        /// </summary>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        public List<Target> Add { get; set; }

        /// <summary>
        /// 删除应用。
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public List<Target> Delete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPolicyTargetReq {\n");
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
            return this.Equals(input as ModifyPolicyTargetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPolicyTargetReq input)
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
