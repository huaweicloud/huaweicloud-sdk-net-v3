using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeInstanceReq 
    {

        /// <summary>
        /// 规格变更后的规格ID。 若只扩展磁盘大小，则规格ID保持和原实例不变。 规格ID请参考[查询实例的扩容规格列表](https://support.huaweicloud.com/api-kafka/ShowInstanceExtendProductInfo.html)接口。
        /// </summary>
        [JsonProperty("new_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSpecCode { get; set; }

        /// <summary>
        /// 规格变更后的消息存储空间，单位：GB。 若扩展实例基准带宽，则new_storage_space不能低于基准带宽规定的最小磁盘大小。 磁盘空间大小请参考[查询实例的扩容规格列表](https://support.huaweicloud.com/api-kafka/ShowInstanceExtendProductInfo.html)接口。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceReq {\n");
            sb.Append("  newSpecCode: ").Append(NewSpecCode).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewSpecCode == input.NewSpecCode ||
                    (this.NewSpecCode != null &&
                    this.NewSpecCode.Equals(input.NewSpecCode))
                ) && 
                (
                    this.NewStorageSpace == input.NewStorageSpace ||
                    (this.NewStorageSpace != null &&
                    this.NewStorageSpace.Equals(input.NewStorageSpace))
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
                if (this.NewSpecCode != null)
                    hashCode = hashCode * 59 + this.NewSpecCode.GetHashCode();
                if (this.NewStorageSpace != null)
                    hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
