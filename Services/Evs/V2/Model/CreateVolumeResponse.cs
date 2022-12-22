using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateVolumeResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID，云硬盘为按需计费时返回该参数。 &gt; 说明： &gt;  &gt; 如果需要查询job的状态，请参考：\&quot;[查询job的状态](https://support.huaweicloud.com/api-evs/evs_04_0054.html)\&quot;。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 订单ID，云硬盘为包周期计费时返回该参数。 &gt; 说明： &gt; 直接在包周期云服务器上新增云硬盘，系统会自动将云硬盘挂载到包周期云服务器上。该情形下也会返回该参数。  &gt; - 如果您需要支付订单，请参考：\&quot;[支付包周期产品订单](https://support.huaweicloud.com/api-oce/zh-cn_topic_0075746561.html)\&quot;。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 待创建的云硬盘ID列表。 &gt; 说明： &gt; 通过云硬盘ID查询云硬盘详情 ，若返回404 可能云硬盘正在创建中或者已经创建失败。 &gt; 通过JobId查询云硬盘创建任务是否完成[查询job的状态](https://support.huaweicloud.com/api-evs/evs_04_0054.html)。
        /// </summary>
        [JsonProperty("volume_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VolumeIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVolumeResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  volumeIds: ").Append(VolumeIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVolumeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVolumeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.VolumeIds == input.VolumeIds ||
                    this.VolumeIds != null &&
                    input.VolumeIds != null &&
                    this.VolumeIds.SequenceEqual(input.VolumeIds)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.VolumeIds != null)
                    hashCode = hashCode * 59 + this.VolumeIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
