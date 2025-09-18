using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowCrossCloudDisasterRelationsRequest 
    {
        /// <summary>
        /// **参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**:   - zh-cn   - en-us  **默认取值**: en-us
        /// </summary>
        /// <value>**参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**:   - zh-cn   - en-us  **默认取值**: en-us</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 容灾角色 - master 主 - disaster 备
        /// </summary>
        /// <value>容灾角色 - master 主 - disaster 备</value>
        [JsonConverter(typeof(EnumClassConverter<DrRoleEnum>))]
        public class DrRoleEnum
        {
            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly DrRoleEnum MASTER = new DrRoleEnum("master");

            /// <summary>
            /// Enum DISASTER for value: disaster
            /// </summary>
            public static readonly DrRoleEnum DISASTER = new DrRoleEnum("disaster");

            private static readonly Dictionary<string, DrRoleEnum> StaticFields =
            new Dictionary<string, DrRoleEnum>()
            {
                { "master", MASTER },
                { "disaster", DISASTER },
            };

            private string _value;

            public DrRoleEnum()
            {

            }

            public DrRoleEnum(string value)
            {
                _value = value;
            }

            public static DrRoleEnum FromValue(string value)
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

                if (this.Equals(obj as DrRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DrRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DrRoleEnum a, DrRoleEnum b)
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

            public static bool operator !=(DrRoleEnum a, DrRoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 容灾类型 - stream - dorado
        /// </summary>
        /// <value>容灾类型 - stream - dorado</value>
        [JsonConverter(typeof(EnumClassConverter<DrTypeEnum>))]
        public class DrTypeEnum
        {
            /// <summary>
            /// Enum STREAM for value: stream
            /// </summary>
            public static readonly DrTypeEnum STREAM = new DrTypeEnum("stream");

            /// <summary>
            /// Enum DORADO for value: dorado
            /// </summary>
            public static readonly DrTypeEnum DORADO = new DrTypeEnum("dorado");

            private static readonly Dictionary<string, DrTypeEnum> StaticFields =
            new Dictionary<string, DrTypeEnum>()
            {
                { "stream", STREAM },
                { "dorado", DORADO },
            };

            private string _value;

            public DrTypeEnum()
            {

            }

            public DrTypeEnum(string value)
            {
                _value = value;
            }

            public static DrTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DrTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DrTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DrTypeEnum a, DrTypeEnum b)
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

            public static bool operator !=(DrTypeEnum a, DrTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 状态 - normal - failover - pending - pre_check_failed - pre_checking
        /// </summary>
        /// <value>状态 - normal - failover - pending - pre_check_failed - pre_checking</value>
        [JsonConverter(typeof(EnumClassConverter<DrStatusEnum>))]
        public class DrStatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly DrStatusEnum NORMAL = new DrStatusEnum("normal");

            /// <summary>
            /// Enum FAILOVER for value: failover
            /// </summary>
            public static readonly DrStatusEnum FAILOVER = new DrStatusEnum("failover");

            /// <summary>
            /// Enum PENDING for value: pending
            /// </summary>
            public static readonly DrStatusEnum PENDING = new DrStatusEnum("pending");

            /// <summary>
            /// Enum PRE_CHECK_FAILED for value: pre_check_failed
            /// </summary>
            public static readonly DrStatusEnum PRE_CHECK_FAILED = new DrStatusEnum("pre_check_failed");

            /// <summary>
            /// Enum PRE_CHECKING for value: pre_checking
            /// </summary>
            public static readonly DrStatusEnum PRE_CHECKING = new DrStatusEnum("pre_checking");

            private static readonly Dictionary<string, DrStatusEnum> StaticFields =
            new Dictionary<string, DrStatusEnum>()
            {
                { "normal", NORMAL },
                { "failover", FAILOVER },
                { "pending", PENDING },
                { "pre_check_failed", PRE_CHECK_FAILED },
                { "pre_checking", PRE_CHECKING },
            };

            private string _value;

            public DrStatusEnum()
            {

            }

            public DrStatusEnum(string value)
            {
                _value = value;
            }

            public static DrStatusEnum FromValue(string value)
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

                if (this.Equals(obj as DrStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DrStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DrStatusEnum a, DrStatusEnum b)
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

            public static bool operator !=(DrStatusEnum a, DrStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**:   - zh-cn   - en-us  **默认取值**: en-us
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 查询记录数。默认为100，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 实例名称，可查询过滤本端实例名称。
        /// </summary>
        [SDKProperty("instance_name", IsQuery = true)]
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例id，可查询过滤本端实例id。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 容灾角色 - master 主 - disaster 备
        /// </summary>
        [SDKProperty("dr_role", IsQuery = true)]
        [JsonProperty("dr_role", NullValueHandling = NullValueHandling.Ignore)]
        public DrRoleEnum DrRole { get; set; }
        /// <summary>
        /// 容灾类型 - stream - dorado
        /// </summary>
        [SDKProperty("dr_type", IsQuery = true)]
        [JsonProperty("dr_type", NullValueHandling = NullValueHandling.Ignore)]
        public DrTypeEnum DrType { get; set; }
        /// <summary>
        /// 状态 - normal - failover - pending - pre_check_failed - pre_checking
        /// </summary>
        [SDKProperty("dr_status", IsQuery = true)]
        [JsonProperty("dr_status", NullValueHandling = NullValueHandling.Ignore)]
        public DrStatusEnum DrStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCrossCloudDisasterRelationsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  drRole: ").Append(DrRole).Append("\n");
            sb.Append("  drType: ").Append(DrType).Append("\n");
            sb.Append("  drStatus: ").Append(DrStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCrossCloudDisasterRelationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCrossCloudDisasterRelationsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.DrRole != input.DrRole) return false;
            if (this.DrType != input.DrType) return false;
            if (this.DrStatus != input.DrStatus) return false;

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
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.DrRole.GetHashCode();
                hashCode = hashCode * 59 + this.DrType.GetHashCode();
                hashCode = hashCode * 59 + this.DrStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
