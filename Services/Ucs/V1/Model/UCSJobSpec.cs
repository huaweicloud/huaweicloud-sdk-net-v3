using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UCSJobSpec 
    {

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("taskList", NullValueHandling = NullValueHandling.Ignore)]
        public List<UCSTask> TaskList { get; set; }

        /// <summary>
        /// 用户的domainID
        /// </summary>
        [JsonProperty("domainID", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainID { get; set; }

        /// <summary>
        /// 操作，create和retry二选一
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// Job等待时间，单位：秒
        /// </summary>
        [JsonProperty("waitTimeOut", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitTimeOut { get; set; }

        /// <summary>
        /// Job类别
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 相关目标
        /// </summary>
        [JsonProperty("relatedObjects", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> RelatedObjects { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCSJobSpec {\n");
            sb.Append("  taskList: ").Append(TaskList).Append("\n");
            sb.Append("  domainID: ").Append(DomainID).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  waitTimeOut: ").Append(WaitTimeOut).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  relatedObjects: ").Append(RelatedObjects).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UCSJobSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UCSJobSpec input)
        {
            if (input == null) return false;
            if (this.TaskList != input.TaskList || (this.TaskList != null && input.TaskList != null && !this.TaskList.SequenceEqual(input.TaskList))) return false;
            if (this.DomainID != input.DomainID || (this.DomainID != null && !this.DomainID.Equals(input.DomainID))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.WaitTimeOut != input.WaitTimeOut || (this.WaitTimeOut != null && !this.WaitTimeOut.Equals(input.WaitTimeOut))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.RelatedObjects != input.RelatedObjects || (this.RelatedObjects != null && input.RelatedObjects != null && !this.RelatedObjects.SequenceEqual(input.RelatedObjects))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && input.ExtendParam != null && !this.ExtendParam.SequenceEqual(input.ExtendParam))) return false;

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
                if (this.TaskList != null) hashCode = hashCode * 59 + this.TaskList.GetHashCode();
                if (this.DomainID != null) hashCode = hashCode * 59 + this.DomainID.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.WaitTimeOut != null) hashCode = hashCode * 59 + this.WaitTimeOut.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RelatedObjects != null) hashCode = hashCode * 59 + this.RelatedObjects.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
