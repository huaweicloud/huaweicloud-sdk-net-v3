using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 凭据对象。
    /// </summary>
    public class Secret 
    {

        /// <summary>
        /// 凭据的资源标识符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 凭据状态，取值如下：  ENABLED：表示启用状态  DISABLED：表示禁用状态  PENDING_DELETE：表示待删除状态  FROZEN：表示冻结状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 用于加密凭据值的KMS主密钥的ID值。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 凭据的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 凭据创建时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 凭据上次更新时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 凭据计划删除时间，时间戳，即从1970年1月1日至该时间的总秒数。  凭据不在删除计划中时，本项值为null。
        /// </summary>
        [JsonProperty("scheduled_delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ScheduledDeleteTime { get; set; }

        /// <summary>
        /// 凭据类型  取值 ： COMMON ：通用凭据(默认)。用于应用系统中的各种敏感信息储存。         RDS ：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// 自动轮转  取值：true 开启, false 关闭(默认)
        /// </summary>
        [JsonProperty("auto_rotation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRotation { get; set; }

        /// <summary>
        /// 轮转周期  约束：6小时-8,760小时 （365天）  类型：Integer[unit] ，Integer表示时间长度 。unit表示时间单位，d（天）、h（小时）、m（分钟）、s（秒）。例如 1d 表示一天，24h也表示一天  说明：当开启自动轮转时，必须填写该值
        /// </summary>
        [JsonProperty("rotation_period", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationPeriod { get; set; }

        /// <summary>
        /// 轮转配置  约束：范围不超过1024个字符。  当secret_type为RDS时，配置为{\&quot;RDSInstanceId\&quot;:\&quot;\&quot;,\&quot;SecretSubType\&quot;:\&quot;\&quot;}  说明：当secret_type为RDS时，必须填写该值  RDSInstanceId为RDS的实例ID,SecretSubType为轮转子类型，取值为：SingleUser，MultiUser。  SingleUser：指定轮转类型为单用户模式轮转，每次轮转将指定账号重置为新的口令。  MultiUser：指定轮转类型为双用户模式轮转，SYSCURRENT和SYSPREVIOUS分别引用其中一个账号。凭据轮转时，SYSPREVIOUS引用的账号口令会被重置为新的随机口令，随后凭据交换SYSCURRENT和SYSPREVIOUS对RDS账号的引用。
        /// </summary>
        [JsonProperty("rotation_config", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationConfig { get; set; }

        /// <summary>
        /// 轮转时间戳
        /// </summary>
        [JsonProperty("rotation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RotationTime { get; set; }

        /// <summary>
        /// 下一次轮转时间戳
        /// </summary>
        [JsonProperty("next_rotation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextRotationTime { get; set; }

        /// <summary>
        /// 凭据订阅的事件列表，当前最大可订阅一个事件。当事件包含的基础事件触发时，通知消息将发送到事件对应的通知主题。
        /// </summary>
        [JsonProperty("event_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventSubscriptions { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secret {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  scheduledDeleteTime: ").Append(ScheduledDeleteTime).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  autoRotation: ").Append(AutoRotation).Append("\n");
            sb.Append("  rotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  rotationConfig: ").Append(RotationConfig).Append("\n");
            sb.Append("  rotationTime: ").Append(RotationTime).Append("\n");
            sb.Append("  nextRotationTime: ").Append(NextRotationTime).Append("\n");
            sb.Append("  eventSubscriptions: ").Append(EventSubscriptions).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Secret);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Secret input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.KmsKeyId == input.KmsKeyId ||
                    (this.KmsKeyId != null &&
                    this.KmsKeyId.Equals(input.KmsKeyId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.ScheduledDeleteTime == input.ScheduledDeleteTime ||
                    (this.ScheduledDeleteTime != null &&
                    this.ScheduledDeleteTime.Equals(input.ScheduledDeleteTime))
                ) && 
                (
                    this.SecretType == input.SecretType ||
                    (this.SecretType != null &&
                    this.SecretType.Equals(input.SecretType))
                ) && 
                (
                    this.AutoRotation == input.AutoRotation ||
                    (this.AutoRotation != null &&
                    this.AutoRotation.Equals(input.AutoRotation))
                ) && 
                (
                    this.RotationPeriod == input.RotationPeriod ||
                    (this.RotationPeriod != null &&
                    this.RotationPeriod.Equals(input.RotationPeriod))
                ) && 
                (
                    this.RotationConfig == input.RotationConfig ||
                    (this.RotationConfig != null &&
                    this.RotationConfig.Equals(input.RotationConfig))
                ) && 
                (
                    this.RotationTime == input.RotationTime ||
                    (this.RotationTime != null &&
                    this.RotationTime.Equals(input.RotationTime))
                ) && 
                (
                    this.NextRotationTime == input.NextRotationTime ||
                    (this.NextRotationTime != null &&
                    this.NextRotationTime.Equals(input.NextRotationTime))
                ) && 
                (
                    this.EventSubscriptions == input.EventSubscriptions ||
                    this.EventSubscriptions != null &&
                    input.EventSubscriptions != null &&
                    this.EventSubscriptions.SequenceEqual(input.EventSubscriptions)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.KmsKeyId != null)
                    hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ScheduledDeleteTime != null)
                    hashCode = hashCode * 59 + this.ScheduledDeleteTime.GetHashCode();
                if (this.SecretType != null)
                    hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.AutoRotation != null)
                    hashCode = hashCode * 59 + this.AutoRotation.GetHashCode();
                if (this.RotationPeriod != null)
                    hashCode = hashCode * 59 + this.RotationPeriod.GetHashCode();
                if (this.RotationConfig != null)
                    hashCode = hashCode * 59 + this.RotationConfig.GetHashCode();
                if (this.RotationTime != null)
                    hashCode = hashCode * 59 + this.RotationTime.GetHashCode();
                if (this.NextRotationTime != null)
                    hashCode = hashCode * 59 + this.NextRotationTime.GetHashCode();
                if (this.EventSubscriptions != null)
                    hashCode = hashCode * 59 + this.EventSubscriptions.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
