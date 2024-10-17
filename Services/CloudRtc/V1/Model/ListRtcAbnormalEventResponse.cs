using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRtcAbnormalEventResponse : SdkResponse
    {

        /// <summary>
        /// 房间ID 
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 用户ID 
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 体验ID 
        /// </summary>
        [JsonProperty("exp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpId { get; set; }

        /// <summary>
        /// 异常信息列表。注意：此字段可能返回null，表示取不到有效值。 
        /// </summary>
        [JsonProperty("abnormal_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RTCCause> AbnormalList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcAbnormalEventResponse {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  expId: ").Append(ExpId).Append("\n");
            sb.Append("  abnormalList: ").Append(AbnormalList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcAbnormalEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcAbnormalEventResponse input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.ExpId != input.ExpId || (this.ExpId != null && !this.ExpId.Equals(input.ExpId))) return false;
            if (this.AbnormalList != input.AbnormalList || (this.AbnormalList != null && input.AbnormalList != null && !this.AbnormalList.SequenceEqual(input.AbnormalList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.ExpId != null) hashCode = hashCode * 59 + this.ExpId.GetHashCode();
                if (this.AbnormalList != null) hashCode = hashCode * 59 + this.AbnormalList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
