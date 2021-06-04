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
    /// 条件中设备消息类型的信息，自定义结构。
    /// </summary>
    public class DeviceMessageCondition 
    {

        /// <summary>
        /// **参数说明**：设备关联的产品ID，用于唯一标识一个产品模型，在管理门户导入产品模型后由平台分配获得。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数说明**：产品关联的topic信息，用于过滤消息中指定topic消息。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceMessageCondition {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceMessageCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceMessageCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                return hashCode;
            }
        }
    }
}
