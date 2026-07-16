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
    /// Request Object
    /// </summary>
    public class DeleteInferDeploymentInstanceRequest 
    {

        /// <summary>
        /// **参数解释：** 服务ID，在[创建服务](CreateInferService.xml)时即可在返回体中获取，也可通过[查询服务列表](ListInferServices.xml)获取当前用户拥有的服务，其中service_id字段即为服务ID。 **约束限制：** 不涉及。 **取值范围：** 服务ID。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("id", IsPath = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 部署名称。
        /// </summary>
        [SDKProperty("deployment_name", IsPath = true)]
        [JsonProperty("deployment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例名字，可以为all，为all时去查询所有的服务实例。 **约束限制：** 不涉及。 **取值范围：** 服务实例名字。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("name", IsPath = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 是否强制删除。 **约束限制：** 不涉及。 **取值范围：** - true：强制删除。 - false：不强制删除。 **默认取值：** false。
        /// </summary>
        [SDKProperty("force", IsQuery = true)]
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// **参数解释：** 删除操作类型。 **约束限制：** 枚举值。 **取值范围：** - DELETE：直接删除，释放资源。 - RECREATE：删除后重建。 **默认取值：** RECREATE。
        /// </summary>
        [SDKProperty("operation", IsQuery = true)]
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInferDeploymentInstanceRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deploymentName: ").Append(DeploymentName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInferDeploymentInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInferDeploymentInstanceRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeploymentName != input.DeploymentName || (this.DeploymentName != null && !this.DeploymentName.Equals(input.DeploymentName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Force != input.Force || (this.Force != null && !this.Force.Equals(input.Force))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeploymentName != null) hashCode = hashCode * 59 + this.DeploymentName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Force != null) hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                return hashCode;
            }
        }
    }
}
