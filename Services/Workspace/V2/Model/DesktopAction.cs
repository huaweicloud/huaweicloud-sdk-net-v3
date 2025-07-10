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
    /// 桌面开关机实体。
    /// </summary>
    public class DesktopAction 
    {

        /// <summary>
        /// 行为动作。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 行为完成状态信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 结果。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 异常信息。
        /// </summary>
        [JsonProperty("traceback", NullValueHandling = NullValueHandling.Ignore)]
        public string Traceback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopAction {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  traceback: ").Append(Traceback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopAction input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Traceback != input.Traceback || (this.Traceback != null && !this.Traceback.Equals(input.Traceback))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Traceback != null) hashCode = hashCode * 59 + this.Traceback.GetHashCode();
                return hashCode;
            }
        }
    }
}
