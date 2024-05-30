using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 更新CA证书结构体。
    /// </summary>
    public class UpdateCertificateDTO 
    {

        /// <summary>
        /// 是否开启自注册能力，当为true时该功能必须配合预调配功能使用，true：是，false：否。
        /// </summary>
        [JsonProperty("provision_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvisionEnable { get; set; }

        /// <summary>
        /// 预调配模板ID，该CA证书绑定的预调配模板id，当该字段传null时表示解除绑定关系。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCertificateDTO {\n");
            sb.Append("  provisionEnable: ").Append(ProvisionEnable).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCertificateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCertificateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProvisionEnable == input.ProvisionEnable ||
                    (this.ProvisionEnable != null &&
                    this.ProvisionEnable.Equals(input.ProvisionEnable))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.ProvisionEnable != null)
                    hashCode = hashCode * 59 + this.ProvisionEnable.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
