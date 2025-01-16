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
        /// 凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        /// <value>凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。</value>
        [JsonConverter(typeof(EnumClassConverter<SecretTypeEnum>))]
        public class SecretTypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly SecretTypeEnum COMMON = new SecretTypeEnum("COMMON");

            /// <summary>
            /// Enum RDS_FG for value: RDS-FG
            /// </summary>
            public static readonly SecretTypeEnum RDS_FG = new SecretTypeEnum("RDS-FG");

            /// <summary>
            /// Enum GAUSSDB_FG for value: GaussDB-FG
            /// </summary>
            public static readonly SecretTypeEnum GAUSSDB_FG = new SecretTypeEnum("GaussDB-FG");

            private static readonly Dictionary<string, SecretTypeEnum> StaticFields =
            new Dictionary<string, SecretTypeEnum>()
            {
                { "COMMON", COMMON },
                { "RDS-FG", RDS_FG },
                { "GaussDB-FG", GAUSSDB_FG },
            };

            private string _value;

            public SecretTypeEnum()
            {

            }

            public SecretTypeEnum(string value)
            {
                _value = value;
            }

            public static SecretTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as SecretTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecretTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecretTypeEnum a, SecretTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SecretTypeEnum a, SecretTypeEnum b)
            {
                return !(a == b);
            }
        }


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
        /// 凭据类型  - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。 - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代） - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。 - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretTypeEnum SecretType { get; set; }
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
        /// 轮转配置  约束：范围不超过1024个字符。  当secret_type为RDS-FG、GaussDB-FG时，配置为{\&quot;InstanceId\&quot;:\&quot;\&quot;,\&quot;SecretSubType\&quot;:\&quot;\&quot;}  说明：当secret_type为RDS-FG、GaussDB-FG时，必须填写该值  InstanceId为实例ID,SecretSubType为轮转子类型，取值为：SingleUser，MultiUser。  SingleUser：指定轮转类型为单用户模式轮转，每次轮转将指定账号重置为新的口令。  MultiUser：指定轮转类型为双用户模式轮转，SYSCURRENT和SYSPREVIOUS分别引用其中一个账号。凭据轮转时，SYSPREVIOUS引用的账号口令会被重置为新的随机口令，随后凭据交换SYSCURRENT和SYSPREVIOUS对账号的引用。
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
        /// FunctionGraph函数的urn。
        /// </summary>
        [JsonProperty("rotation_func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationFuncUrn { get; set; }



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
            sb.Append("  rotationFuncUrn: ").Append(RotationFuncUrn).Append("\n");
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
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.KmsKeyId != input.KmsKeyId || (this.KmsKeyId != null && !this.KmsKeyId.Equals(input.KmsKeyId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ScheduledDeleteTime != input.ScheduledDeleteTime || (this.ScheduledDeleteTime != null && !this.ScheduledDeleteTime.Equals(input.ScheduledDeleteTime))) return false;
            if (this.SecretType != input.SecretType) return false;
            if (this.AutoRotation != input.AutoRotation || (this.AutoRotation != null && !this.AutoRotation.Equals(input.AutoRotation))) return false;
            if (this.RotationPeriod != input.RotationPeriod || (this.RotationPeriod != null && !this.RotationPeriod.Equals(input.RotationPeriod))) return false;
            if (this.RotationConfig != input.RotationConfig || (this.RotationConfig != null && !this.RotationConfig.Equals(input.RotationConfig))) return false;
            if (this.RotationTime != input.RotationTime || (this.RotationTime != null && !this.RotationTime.Equals(input.RotationTime))) return false;
            if (this.NextRotationTime != input.NextRotationTime || (this.NextRotationTime != null && !this.NextRotationTime.Equals(input.NextRotationTime))) return false;
            if (this.EventSubscriptions != input.EventSubscriptions || (this.EventSubscriptions != null && input.EventSubscriptions != null && !this.EventSubscriptions.SequenceEqual(input.EventSubscriptions))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.RotationFuncUrn != input.RotationFuncUrn || (this.RotationFuncUrn != null && !this.RotationFuncUrn.Equals(input.RotationFuncUrn))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.KmsKeyId != null) hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ScheduledDeleteTime != null) hashCode = hashCode * 59 + this.ScheduledDeleteTime.GetHashCode();
                hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.AutoRotation != null) hashCode = hashCode * 59 + this.AutoRotation.GetHashCode();
                if (this.RotationPeriod != null) hashCode = hashCode * 59 + this.RotationPeriod.GetHashCode();
                if (this.RotationConfig != null) hashCode = hashCode * 59 + this.RotationConfig.GetHashCode();
                if (this.RotationTime != null) hashCode = hashCode * 59 + this.RotationTime.GetHashCode();
                if (this.NextRotationTime != null) hashCode = hashCode * 59 + this.NextRotationTime.GetHashCode();
                if (this.EventSubscriptions != null) hashCode = hashCode * 59 + this.EventSubscriptions.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.RotationFuncUrn != null) hashCode = hashCode * 59 + this.RotationFuncUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
