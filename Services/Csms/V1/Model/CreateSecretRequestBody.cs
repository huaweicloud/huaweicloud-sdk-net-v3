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
    /// 创建凭据请求消息体。
    /// </summary>
    public class CreateSecretRequestBody 
    {
        /// <summary>
        /// 凭据类型   - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。  - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代）  - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。  - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        /// <value>凭据类型   - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。  - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代）  - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。  - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。</value>
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
                if (ReferenceEquals(a, b))
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
        /// 待创建凭据的名称。  约束：取值范围为1到64个字符，满足正则匹配“^[a-zA-Z0-9_-]{1,64}$”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用于加密保护凭据值的KMS主密钥ID，如果您未指定此参数，凭据管理服务将默认使用名为csms/default的默认主密钥，用于加密您账号在本项目中创建的凭据值。如果用户账号下不存在该名称的主密钥，则凭据管理服务自动为您创建该名称的密钥。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 凭据的描述信息。  约束：2048字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 二进制类型凭据在base64编码后的明文，凭据管理服务将其加密后，存入凭据的初始版本中。  类型：base64编码的二进制数据对象。  约束：secret_binary和secret_string必须且只能设置一个，最大32K。
        /// </summary>
        [JsonProperty("secret_binary", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretBinary { get; set; }

        /// <summary>
        /// 文本类型凭据的明文，凭据管理服务将其加密后，存入凭据的初始版本中。  约束：secret_binary和secret_string必须且只能设置一个，最大32K。
        /// </summary>
        [JsonProperty("secret_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretString { get; set; }

        /// <summary>
        /// 凭据类型   - COMMON：通用凭据(默认)。用于应用系统中的各种敏感信息储存。  - RDS：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。（已不支持，使用RDS-FG替代）  - RDS-FG：RDS凭据 。专门针对RDS的凭据，用于存储RDS的账号信息。  - GaussDB-FG：TaurusDB凭据。专门针对TaurusDB的凭据，用于存储TaurusDB的账号信息。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretTypeEnum SecretType { get; set; }
        /// <summary>
        /// 自动轮转  取值：true 开启 ,false 关闭 (默认)
        /// </summary>
        [JsonProperty("auto_rotation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRotation { get; set; }

        /// <summary>
        /// 轮转周期  约束：6小时-8,760小时 （365天）  类型：Integer[unit] ，Integer表示时间长度 。unit表示时间单位，d（天）、h（小时）、m（分钟）、s（秒）。例如 1d 表示一天，24h也表示一天  说明：当开启自动轮转时，必须填写该值
        /// </summary>
        [JsonProperty("rotation_period", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationPeriod { get; set; }

        /// <summary>
        /// 轮转配置  约束：范围不超过1024个字符。  当secret_type为RDS-FG、GaussDB-FG时，必须填写本参数，参数格式为{\&quot;InstanceId\&quot;:\&quot;\&quot;,\&quot;SecretSubType\&quot;:\&quot;\&quot;}  参数说明：InstanceId为实例ID,SecretSubType为轮转子类型，取值为：SingleUser，MultiUser。  SingleUser：指定轮转类型为单用户模式轮转，每次轮转将指定账号重置为新的口令。  MultiUser：指定轮转类型为双用户模式轮转，SYSCURRENT和SYSPREVIOUS分别引用其中一个账号。凭据轮转时，SYSPREVIOUS引用的账号口令会被重置为新的随机口令，随后凭据交换SYSCURRENT和SYSPREVIOUS对账号的引用。
        /// </summary>
        [JsonProperty("rotation_config", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationConfig { get; set; }

        /// <summary>
        /// 凭据订阅的事件列表，当前最大可订阅一个事件。当事件包含的基础事件触发时，通知消息将发送到事件对应的通知主题。
        /// </summary>
        [JsonProperty("event_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventSubscriptions { get; set; }

        /// <summary>
        /// 该参数针对企业用户使用。如果您是企业用户，且已创建企业项目，则请从下拉列表中为密钥选择需要绑定的企业项目，默认项目为“default”。 未开通企业管理的用户页面则没有“企业项目”参数项，无需进行配置。
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
            sb.Append("class CreateSecretRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  secretBinary: ").Append(SecretBinary).Append("\n");
            sb.Append("  secretString: ").Append(SecretString).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  autoRotation: ").Append(AutoRotation).Append("\n");
            sb.Append("  rotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  rotationConfig: ").Append(RotationConfig).Append("\n");
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
            return this.Equals(input as CreateSecretRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.KmsKeyId != input.KmsKeyId || (this.KmsKeyId != null && !this.KmsKeyId.Equals(input.KmsKeyId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SecretBinary != input.SecretBinary || (this.SecretBinary != null && !this.SecretBinary.Equals(input.SecretBinary))) return false;
            if (this.SecretString != input.SecretString || (this.SecretString != null && !this.SecretString.Equals(input.SecretString))) return false;
            if (this.SecretType != input.SecretType) return false;
            if (this.AutoRotation != input.AutoRotation || (this.AutoRotation != null && !this.AutoRotation.Equals(input.AutoRotation))) return false;
            if (this.RotationPeriod != input.RotationPeriod || (this.RotationPeriod != null && !this.RotationPeriod.Equals(input.RotationPeriod))) return false;
            if (this.RotationConfig != input.RotationConfig || (this.RotationConfig != null && !this.RotationConfig.Equals(input.RotationConfig))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.KmsKeyId != null) hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecretBinary != null) hashCode = hashCode * 59 + this.SecretBinary.GetHashCode();
                if (this.SecretString != null) hashCode = hashCode * 59 + this.SecretString.GetHashCode();
                hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.AutoRotation != null) hashCode = hashCode * 59 + this.AutoRotation.GetHashCode();
                if (this.RotationPeriod != null) hashCode = hashCode * 59 + this.RotationPeriod.GetHashCode();
                if (this.RotationConfig != null) hashCode = hashCode * 59 + this.RotationConfig.GetHashCode();
                if (this.EventSubscriptions != null) hashCode = hashCode * 59 + this.EventSubscriptions.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.RotationFuncUrn != null) hashCode = hashCode * 59 + this.RotationFuncUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
