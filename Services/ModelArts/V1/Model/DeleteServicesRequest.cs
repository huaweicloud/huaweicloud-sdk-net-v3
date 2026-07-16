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
    /// 提供待删除的services id列表。
    /// </summary>
    public class DeleteServicesRequest 
    {

        /// <summary>
        /// **参数解释：** 待删除的servicesid列表。服务ID在[创建服务](CreateInferService.xml)时即可在返回体中获取，也可通过[查询服务列表](ListInferServices.xml)获取当前用户拥有的服务，其中service_id字段即为服务ID。 **约束限制：** 不涉及。 **取值范围：** 服务ID。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("service_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServiceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServicesRequest {\n");
            sb.Append("  serviceIds: ").Append(ServiceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServicesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServicesRequest input)
        {
            if (input == null) return false;
            if (this.ServiceIds != input.ServiceIds || (this.ServiceIds != null && input.ServiceIds != null && !this.ServiceIds.SequenceEqual(input.ServiceIds))) return false;

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
                if (this.ServiceIds != null) hashCode = hashCode * 59 + this.ServiceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
