using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskV2RequestBody 
    {

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 部署编排列表信息
        /// </summary>
        [JsonProperty("operation_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeployV2OperationsDO> OperationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskV2RequestBody {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  operationList: ").Append(OperationList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskV2RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.OperationList == input.OperationList ||
                    this.OperationList != null &&
                    input.OperationList != null &&
                    this.OperationList.SequenceEqual(input.OperationList)
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.OperationList != null)
                    hashCode = hashCode * 59 + this.OperationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
