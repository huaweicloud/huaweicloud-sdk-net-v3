using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 主持人选看请求。
    /// </summary>
    public class RestChairViewReqBody 
    {

        /// <summary>
        /// 主持人观看的画面类型。 - 0: 主持人轮询 - 1: 主持人观看多画面 - 2: 主持人选看会场
        /// </summary>
        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ViewType { get; set; }

        /// <summary>
        /// 被主持人选看的会场。 当为主持人选看会场时为必填参数。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 轮询间隔，单位：秒。 主持人轮询时，必填字段。 范围:[10-120]，默认值：10。
        /// </summary>
        [JsonProperty("switchTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchTime { get; set; }

        /// <summary>
        /// 启动/停止轮询。 主持人轮询时，必填字段。 - 0: 停止轮询 - 1: 启动轮询
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestChairViewReqBody {\n");
            sb.Append("  viewType: ").Append(ViewType).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  switchTime: ").Append(SwitchTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestChairViewReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestChairViewReqBody input)
        {
            if (input == null) return false;
            if (this.ViewType != input.ViewType || (this.ViewType != null && !this.ViewType.Equals(input.ViewType))) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.SwitchTime != input.SwitchTime || (this.SwitchTime != null && !this.SwitchTime.Equals(input.SwitchTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ViewType != null) hashCode = hashCode * 59 + this.ViewType.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.SwitchTime != null) hashCode = hashCode * 59 + this.SwitchTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
