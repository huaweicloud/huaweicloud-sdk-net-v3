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
    /// 
    /// </summary>
    public class InstanceStatusStatistics 
    {

        /// <summary>
        /// 统计对象名称(虚拟机组名称、桌面组名称)。
        /// </summary>
        [JsonProperty("static_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StaticName { get; set; }

        /// <summary>
        /// 运行数目(运行中、启动中、故障迁移中、迁移中)。
        /// </summary>
        [JsonProperty("running_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningNum { get; set; }

        /// <summary>
        /// 关机数目(关机中、已关机)。
        /// </summary>
        [JsonProperty("stop_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? StopNum { get; set; }

        /// <summary>
        /// 休眠数目(休眠中、已休眠)。
        /// </summary>
        [JsonProperty("hibernate_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HibernateNum { get; set; }

        /// <summary>
        /// 其他(未知、删除失败、删除中)。
        /// </summary>
        [JsonProperty("other_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OtherNum { get; set; }

        /// <summary>
        /// 已分配数目。
        /// </summary>
        [JsonProperty("attached_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachedNum { get; set; }

        /// <summary>
        /// 未分配数目。
        /// </summary>
        [JsonProperty("unattached_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnattachedNum { get; set; }

        /// <summary>
        /// 不可分配数目(分配失败、解分配失败、解分配成功)。
        /// </summary>
        [JsonProperty("cannot_attach_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CannotAttachNum { get; set; }

        /// <summary>
        /// 处理中(分配中、解分配中)。
        /// </summary>
        [JsonProperty("in_process_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InProcessNum { get; set; }

        /// <summary>
        /// 使用中数目。
        /// </summary>
        [JsonProperty("in_use_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InUseNum { get; set; }

        /// <summary>
        /// 未注册数目。
        /// </summary>
        [JsonProperty("unregistered_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnregisteredNum { get; set; }

        /// <summary>
        /// 空闲数目。
        /// </summary>
        [JsonProperty("ready_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadyNum { get; set; }

        /// <summary>
        /// 断开连接数目。
        /// </summary>
        [JsonProperty("disconnected_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectedNum { get; set; }

        /// <summary>
        /// 未知数目。
        /// </summary>
        [JsonProperty("unknown_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnknownNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceStatusStatistics {\n");
            sb.Append("  staticName: ").Append(StaticName).Append("\n");
            sb.Append("  runningNum: ").Append(RunningNum).Append("\n");
            sb.Append("  stopNum: ").Append(StopNum).Append("\n");
            sb.Append("  hibernateNum: ").Append(HibernateNum).Append("\n");
            sb.Append("  otherNum: ").Append(OtherNum).Append("\n");
            sb.Append("  attachedNum: ").Append(AttachedNum).Append("\n");
            sb.Append("  unattachedNum: ").Append(UnattachedNum).Append("\n");
            sb.Append("  cannotAttachNum: ").Append(CannotAttachNum).Append("\n");
            sb.Append("  inProcessNum: ").Append(InProcessNum).Append("\n");
            sb.Append("  inUseNum: ").Append(InUseNum).Append("\n");
            sb.Append("  unregisteredNum: ").Append(UnregisteredNum).Append("\n");
            sb.Append("  readyNum: ").Append(ReadyNum).Append("\n");
            sb.Append("  disconnectedNum: ").Append(DisconnectedNum).Append("\n");
            sb.Append("  unknownNum: ").Append(UnknownNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceStatusStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceStatusStatistics input)
        {
            if (input == null) return false;
            if (this.StaticName != input.StaticName || (this.StaticName != null && !this.StaticName.Equals(input.StaticName))) return false;
            if (this.RunningNum != input.RunningNum || (this.RunningNum != null && !this.RunningNum.Equals(input.RunningNum))) return false;
            if (this.StopNum != input.StopNum || (this.StopNum != null && !this.StopNum.Equals(input.StopNum))) return false;
            if (this.HibernateNum != input.HibernateNum || (this.HibernateNum != null && !this.HibernateNum.Equals(input.HibernateNum))) return false;
            if (this.OtherNum != input.OtherNum || (this.OtherNum != null && !this.OtherNum.Equals(input.OtherNum))) return false;
            if (this.AttachedNum != input.AttachedNum || (this.AttachedNum != null && !this.AttachedNum.Equals(input.AttachedNum))) return false;
            if (this.UnattachedNum != input.UnattachedNum || (this.UnattachedNum != null && !this.UnattachedNum.Equals(input.UnattachedNum))) return false;
            if (this.CannotAttachNum != input.CannotAttachNum || (this.CannotAttachNum != null && !this.CannotAttachNum.Equals(input.CannotAttachNum))) return false;
            if (this.InProcessNum != input.InProcessNum || (this.InProcessNum != null && !this.InProcessNum.Equals(input.InProcessNum))) return false;
            if (this.InUseNum != input.InUseNum || (this.InUseNum != null && !this.InUseNum.Equals(input.InUseNum))) return false;
            if (this.UnregisteredNum != input.UnregisteredNum || (this.UnregisteredNum != null && !this.UnregisteredNum.Equals(input.UnregisteredNum))) return false;
            if (this.ReadyNum != input.ReadyNum || (this.ReadyNum != null && !this.ReadyNum.Equals(input.ReadyNum))) return false;
            if (this.DisconnectedNum != input.DisconnectedNum || (this.DisconnectedNum != null && !this.DisconnectedNum.Equals(input.DisconnectedNum))) return false;
            if (this.UnknownNum != input.UnknownNum || (this.UnknownNum != null && !this.UnknownNum.Equals(input.UnknownNum))) return false;

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
                if (this.StaticName != null) hashCode = hashCode * 59 + this.StaticName.GetHashCode();
                if (this.RunningNum != null) hashCode = hashCode * 59 + this.RunningNum.GetHashCode();
                if (this.StopNum != null) hashCode = hashCode * 59 + this.StopNum.GetHashCode();
                if (this.HibernateNum != null) hashCode = hashCode * 59 + this.HibernateNum.GetHashCode();
                if (this.OtherNum != null) hashCode = hashCode * 59 + this.OtherNum.GetHashCode();
                if (this.AttachedNum != null) hashCode = hashCode * 59 + this.AttachedNum.GetHashCode();
                if (this.UnattachedNum != null) hashCode = hashCode * 59 + this.UnattachedNum.GetHashCode();
                if (this.CannotAttachNum != null) hashCode = hashCode * 59 + this.CannotAttachNum.GetHashCode();
                if (this.InProcessNum != null) hashCode = hashCode * 59 + this.InProcessNum.GetHashCode();
                if (this.InUseNum != null) hashCode = hashCode * 59 + this.InUseNum.GetHashCode();
                if (this.UnregisteredNum != null) hashCode = hashCode * 59 + this.UnregisteredNum.GetHashCode();
                if (this.ReadyNum != null) hashCode = hashCode * 59 + this.ReadyNum.GetHashCode();
                if (this.DisconnectedNum != null) hashCode = hashCode * 59 + this.DisconnectedNum.GetHashCode();
                if (this.UnknownNum != null) hashCode = hashCode * 59 + this.UnknownNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
