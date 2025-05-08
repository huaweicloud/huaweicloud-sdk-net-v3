using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesRequest 
    {
        /// <summary>
        /// **参数解释**： 消息引擎。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 消息引擎。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum ROCKETMQ for value: rocketmq
            /// </summary>
            public static readonly EngineEnum ROCKETMQ = new EngineEnum("rocketmq");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "rocketmq", ROCKETMQ },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 实例状态，[详细状态说明请参考[实例状态说明](hrm-api-0010.xml)。](tag:hws,hws_hk,ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm)[详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)。](tag:hcs,fcs) **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 实例状态，[详细状态说明请参考[实例状态说明](hrm-api-0010.xml)。](tag:hws,hws_hk,ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm)[详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)。](tag:hcs,fcs) **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum RESTARTING for value: RESTARTING
            /// </summary>
            public static readonly StatusEnum RESTARTING = new StatusEnum("RESTARTING");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum CREATEFAILED for value: CREATEFAILED
            /// </summary>
            public static readonly StatusEnum CREATEFAILED = new StatusEnum("CREATEFAILED");

            /// <summary>
            /// Enum FREEZING for value: FREEZING
            /// </summary>
            public static readonly StatusEnum FREEZING = new StatusEnum("FREEZING");

            /// <summary>
            /// Enum FROZEN for value: FROZEN
            /// </summary>
            public static readonly StatusEnum FROZEN = new StatusEnum("FROZEN");

            /// <summary>
            /// Enum EXTENDING for value: EXTENDING
            /// </summary>
            public static readonly StatusEnum EXTENDING = new StatusEnum("EXTENDING");

            /// <summary>
            /// Enum SHRINKING for value: SHRINKING
            /// </summary>
            public static readonly StatusEnum SHRINKING = new StatusEnum("SHRINKING");

            /// <summary>
            /// Enum EXTENDEDFAILED for value: EXTENDEDFAILED
            /// </summary>
            public static readonly StatusEnum EXTENDEDFAILED = new StatusEnum("EXTENDEDFAILED");

            /// <summary>
            /// Enum CONFIGURING for value: CONFIGURING
            /// </summary>
            public static readonly StatusEnum CONFIGURING = new StatusEnum("CONFIGURING");

            /// <summary>
            /// Enum ROLLBACK for value: ROLLBACK
            /// </summary>
            public static readonly StatusEnum ROLLBACK = new StatusEnum("ROLLBACK");

            /// <summary>
            /// Enum ROLLBACKFAILED for value: ROLLBACKFAILED
            /// </summary>
            public static readonly StatusEnum ROLLBACKFAILED = new StatusEnum("ROLLBACKFAILED");

            /// <summary>
            /// Enum VOLUMETYPECHANGING for value: VOLUMETYPECHANGING
            /// </summary>
            public static readonly StatusEnum VOLUMETYPECHANGING = new StatusEnum("VOLUMETYPECHANGING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "RUNNING", RUNNING },
                { "RESTARTING", RESTARTING },
                { "DELETING", DELETING },
                { "ERROR", ERROR },
                { "CREATEFAILED", CREATEFAILED },
                { "FREEZING", FREEZING },
                { "FROZEN", FROZEN },
                { "EXTENDING", EXTENDING },
                { "SHRINKING", SHRINKING },
                { "EXTENDEDFAILED", EXTENDEDFAILED },
                { "CONFIGURING", CONFIGURING },
                { "ROLLBACK", ROLLBACK },
                { "ROLLBACKFAILED", ROLLBACKFAILED },
                { "VOLUMETYPECHANGING", VOLUMETYPECHANGING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 是否返回创建失败的实例数。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：返回创建失败的实例数。 - &#39;false&#39;：不返回创建失败的实例数。  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 是否返回创建失败的实例数。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：返回创建失败的实例数。 - &#39;false&#39;：不返回创建失败的实例数。  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<IncludeFailureEnum>))]
        public class IncludeFailureEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IncludeFailureEnum TRUE = new IncludeFailureEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IncludeFailureEnum FALSE = new IncludeFailureEnum("false");

            private static readonly Dictionary<string, IncludeFailureEnum> StaticFields =
            new Dictionary<string, IncludeFailureEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IncludeFailureEnum()
            {

            }

            public IncludeFailureEnum(string value)
            {
                _value = value;
            }

            public static IncludeFailureEnum FromValue(string value)
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

                if (this.Equals(obj as IncludeFailureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IncludeFailureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IncludeFailureEnum a, IncludeFailureEnum b)
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

            public static bool operator !=(IncludeFailureEnum a, IncludeFailureEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 是否按照实例名称进行精确匹配查询。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：表示按照实例名称进行精确匹配查询。 - &#39;false&#39;：表示模糊匹配实例名称查询。  **默认取值**： &#39;false&#39;。
        /// </summary>
        /// <value>**参数解释**： 是否按照实例名称进行精确匹配查询。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：表示按照实例名称进行精确匹配查询。 - &#39;false&#39;：表示模糊匹配实例名称查询。  **默认取值**： &#39;false&#39;。</value>
        [JsonConverter(typeof(EnumClassConverter<ExactMatchNameEnum>))]
        public class ExactMatchNameEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ExactMatchNameEnum TRUE = new ExactMatchNameEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ExactMatchNameEnum FALSE = new ExactMatchNameEnum("false");

            private static readonly Dictionary<string, ExactMatchNameEnum> StaticFields =
            new Dictionary<string, ExactMatchNameEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public ExactMatchNameEnum()
            {

            }

            public ExactMatchNameEnum(string value)
            {
                _value = value;
            }

            public static ExactMatchNameEnum FromValue(string value)
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

                if (this.Equals(obj as ExactMatchNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExactMatchNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExactMatchNameEnum a, ExactMatchNameEnum b)
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

            public static bool operator !=(ExactMatchNameEnum a, ExactMatchNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 消息引擎。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// **参数解释**： 实例名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID。获取方法如下：登录RocketMQ控制台，在RocketMQ实例详情页面查找实例ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 实例状态，[详细状态说明请参考[实例状态说明](hrm-api-0010.xml)。](tag:hws,hws_hk,ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm)[详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)。](tag:hcs,fcs) **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 是否返回创建失败的实例数。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：返回创建失败的实例数。 - &#39;false&#39;：不返回创建失败的实例数。  **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        [JsonProperty("include_failure", NullValueHandling = NullValueHandling.Ignore)]
        public IncludeFailureEnum IncludeFailure { get; set; }
        /// <summary>
        /// **参数解释**： 是否按照实例名称进行精确匹配查询。 **约束限制**： 不涉及。 **取值范围**： - &#39;true&#39;：表示按照实例名称进行精确匹配查询。 - &#39;false&#39;：表示模糊匹配实例名称查询。  **默认取值**： &#39;false&#39;。
        /// </summary>
        [SDKProperty("exact_match_name", IsQuery = true)]
        [JsonProperty("exact_match_name", NullValueHandling = NullValueHandling.Ignore)]
        public ExactMatchNameEnum ExactMatchName { get; set; }
        /// <summary>
        /// **参数解释**： 企业项目ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 当次查询返回的实例最大个数。 **约束限制**： 不涉及。 **取值范围**： 1~50。 **默认取值**： 10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量，表示从此偏移量开始查询。 **约束限制**： 不涉及。 **取值范围**： 大于等于0。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  includeFailure: ").Append(IncludeFailure).Append("\n");
            sb.Append("  exactMatchName: ").Append(ExactMatchName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRequest input)
        {
            if (input == null) return false;
            if (this.Engine != input.Engine) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status) return false;
            if (this.IncludeFailure != input.IncludeFailure) return false;
            if (this.ExactMatchName != input.ExactMatchName) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                hashCode = hashCode * 59 + this.ExactMatchName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
