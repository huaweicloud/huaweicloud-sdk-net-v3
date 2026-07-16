using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AcceptScheduledEventResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：事件分类。 **取值范围**：可选值如下： - hardware：硬件维修。 - software：软件维修。
        /// </summary>
        /// <value>**参数解释**：事件分类。 **取值范围**：可选值如下： - hardware：硬件维修。 - software：软件维修。</value>
        [JsonConverter(typeof(EnumClassConverter<CatalogEnum>))]
        public class CatalogEnum
        {
            /// <summary>
            /// Enum SOFTWARE for value: software
            /// </summary>
            public static readonly CatalogEnum SOFTWARE = new CatalogEnum("software");

            /// <summary>
            /// Enum HARDWARE for value: hardware
            /// </summary>
            public static readonly CatalogEnum HARDWARE = new CatalogEnum("hardware");

            private static readonly Dictionary<string, CatalogEnum> StaticFields =
            new Dictionary<string, CatalogEnum>()
            {
                { "software", SOFTWARE },
                { "hardware", HARDWARE },
            };

            private string _value;

            public CatalogEnum()
            {

            }

            public CatalogEnum(string value)
            {
                _value = value;
            }

            public static CatalogEnum FromValue(string value)
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

                if (this.Equals(obj as CatalogEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CatalogEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CatalogEnum a, CatalogEnum b)
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

            public static bool operator !=(CatalogEnum a, CatalogEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：事件类型。 **取值范围**：可选值如下： - system-maintenance：系统维护 - localdisk-recovery：本地盘恢复 - node_reboot：节点重启 - operation-request：运维授权 - node_maintenance：超节点维护 - node_redeploy：超节点重部署 - node_localdisk_recovery 超节点本地盘恢复。
        /// </summary>
        /// <value>**参数解释**：事件类型。 **取值范围**：可选值如下： - system-maintenance：系统维护 - localdisk-recovery：本地盘恢复 - node_reboot：节点重启 - operation-request：运维授权 - node_maintenance：超节点维护 - node_redeploy：超节点重部署 - node_localdisk_recovery 超节点本地盘恢复。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SYSTEM_MAINTENANCE for value: system-maintenance
            /// </summary>
            public static readonly TypeEnum SYSTEM_MAINTENANCE = new TypeEnum("system-maintenance");

            /// <summary>
            /// Enum LOCALDISK_RECOVERY for value: localdisk-recovery
            /// </summary>
            public static readonly TypeEnum LOCALDISK_RECOVERY = new TypeEnum("localdisk-recovery");

            /// <summary>
            /// Enum NODE_REBOOT for value: node_reboot
            /// </summary>
            public static readonly TypeEnum NODE_REBOOT = new TypeEnum("node_reboot");

            /// <summary>
            /// Enum OPERATION_REQUEST for value: operation-request
            /// </summary>
            public static readonly TypeEnum OPERATION_REQUEST = new TypeEnum("operation-request");

            /// <summary>
            /// Enum NODE_MAINTENANCE for value: node_maintenance
            /// </summary>
            public static readonly TypeEnum NODE_MAINTENANCE = new TypeEnum("node_maintenance");

            /// <summary>
            /// Enum NODE_REDEPLOY for value: node_redeploy
            /// </summary>
            public static readonly TypeEnum NODE_REDEPLOY = new TypeEnum("node_redeploy");

            /// <summary>
            /// Enum NODE_LOCALDISK_RECOVERY for value: node_localdisk_recovery
            /// </summary>
            public static readonly TypeEnum NODE_LOCALDISK_RECOVERY = new TypeEnum("node_localdisk_recovery");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "system-maintenance", SYSTEM_MAINTENANCE },
                { "localdisk-recovery", LOCALDISK_RECOVERY },
                { "node_reboot", NODE_REBOOT },
                { "operation-request", OPERATION_REQUEST },
                { "node_maintenance", NODE_MAINTENANCE },
                { "node_redeploy", NODE_REDEPLOY },
                { "node_localdisk_recovery", NODE_LOCALDISK_RECOVERY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：事件状态。 **取值范围**：可选择值如下： - inquiring: 待授权, - scheduled: 待执行, - executing: 执行中, - completed: 执行成功 - failed: 执行失败 - canceled: 取消
        /// </summary>
        /// <value>**参数解释**：事件状态。 **取值范围**：可选择值如下： - inquiring: 待授权, - scheduled: 待执行, - executing: 执行中, - completed: 执行成功 - failed: 执行失败 - canceled: 取消</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum INQUIRING for value: inquiring
            /// </summary>
            public static readonly StateEnum INQUIRING = new StateEnum("inquiring");

            /// <summary>
            /// Enum SCHEDULED for value: scheduled
            /// </summary>
            public static readonly StateEnum SCHEDULED = new StateEnum("scheduled");

            /// <summary>
            /// Enum EXECUTING for value: executing
            /// </summary>
            public static readonly StateEnum EXECUTING = new StateEnum("executing");

            /// <summary>
            /// Enum COMPLETED for value: completed
            /// </summary>
            public static readonly StateEnum COMPLETED = new StateEnum("completed");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("failed");

            /// <summary>
            /// Enum CANCELED for value: canceled
            /// </summary>
            public static readonly StateEnum CANCELED = new StateEnum("canceled");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "inquiring", INQUIRING },
                { "scheduled", SCHEDULED },
                { "executing", EXECUTING },
                { "completed", COMPLETED },
                { "failed", FAILED },
                { "canceled", CANCELED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：节点类型归属。 **取值范围**可选择值如下： - devserver：lite-server节点 - lite-cluster lite池 - standard 标准池
        /// </summary>
        /// <value>**参数解释**：节点类型归属。 **取值范围**可选择值如下： - devserver：lite-server节点 - lite-cluster lite池 - standard 标准池</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum DEVSERVER for value: devserver
            /// </summary>
            public static readonly InstanceTypeEnum DEVSERVER = new InstanceTypeEnum("devserver");

            /// <summary>
            /// Enum LITE_CLUSTER for value: lite-cluster
            /// </summary>
            public static readonly InstanceTypeEnum LITE_CLUSTER = new InstanceTypeEnum("lite-cluster");

            /// <summary>
            /// Enum STANDARD for value: standard
            /// </summary>
            public static readonly InstanceTypeEnum STANDARD = new InstanceTypeEnum("standard");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "devserver", DEVSERVER },
                { "lite-cluster", LITE_CLUSTER },
                { "standard", STANDARD },
            };

            private string _value;

            public InstanceTypeEnum()
            {

            }

            public InstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static InstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTypeEnum a, InstanceTypeEnum b)
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：计划事件ID，取值查询计划事件列表接口的event_id字段。 系统自动生成，只能以小写字母开头，数字、中划线组成，不能以中划线结尾，长度小于63。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：事件分类。 **取值范围**：可选值如下： - hardware：硬件维修。 - software：软件维修。
        /// </summary>
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public CatalogEnum Catalog { get; set; }
        /// <summary>
        /// **参数解释**：事件类型。 **取值范围**：可选值如下： - system-maintenance：系统维护 - localdisk-recovery：本地盘恢复 - node_reboot：节点重启 - operation-request：运维授权 - node_maintenance：超节点维护 - node_redeploy：超节点重部署 - node_localdisk_recovery 超节点本地盘恢复。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：对计划事件的描述信息。系统自动生成。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：事件状态。 **取值范围**：可选择值如下： - inquiring: 待授权, - scheduled: 待执行, - executing: 执行中, - completed: 执行成功 - failed: 执行失败 - canceled: 取消
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释**：节点类型归属。 **取值范围**可选择值如下： - devserver：lite-server节点 - lite-cluster lite池 - standard 标准池
        /// </summary>
        [JsonProperty("instanceType", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// **参数解释**：服务器ID。计算服务系统自动生成的实例ID，长度小于63。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("instanceId", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：节点名称，取值自节点详情的metadata.name字段。系统自动生成，只能以小写字母开头，数字、中划线组成，不能以中划线结尾，小于63个字符。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// **参数解释**：资源池名称, lite-cluster、standard才具有，取值自资源池详情的metadata.name字段。系统自动生成，只能以小写字母开头，数字、中划线组成，不能以中划线结尾，小于63个字符。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("poolName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：资源池对外显示的名称, lite-cluster、standard才具有，取值自资源池详情的metadata.name字段。只能以小写字母开头，数字、中划线组成，不能以中划线结尾，且长度为[36-63]个字符。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("poolDisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolDisplayName { get; set; }

        /// <summary>
        /// **参数解释**：事件发布时间。 **约束限制**：格式为UTC时间字符串：2025-09-15T07:02:30Z。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("publishTime", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTime { get; set; }

        /// <summary>
        /// **参数解释**：事件开始时间。 **约束限制**：格式为UTC时间字符串：2025-09-15T07:02:30Z。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：事件完成时间。 **约束限制**：格式为UTC时间字符串：2025-09-15T07:02:30Z。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("finishTime", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// **参数解释**：事件计划执行开始时间，格式为UTC时间字符串：2025-09-15T07:02:30Z。 **约束限制**：大于当前时间。 **取值范围**：不涉及。 **默认取值**：不填表示立即执行。
        /// </summary>
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// **参数解释**：提示信息。 **约束限制**：系统自动生成，只能以小写字母开头，数字、中划线组成，不能以中划线结尾，长度小于63字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("probeMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string ProbeMsg { get; set; }

        /// <summary>
        /// **参数解释**：节点的重部署类型。 **约束限制**：不涉及。 **取值范围**：可选值如下：- HARD：表示支持强制重部署, - SOFT：表示支持重部署 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("redeployType", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RedeployType { get; set; }

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
            sb.Append("class AcceptScheduledEventResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  poolDisplayName: ").Append(PoolDisplayName).Append("\n");
            sb.Append("  publishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  probeMsg: ").Append(ProbeMsg).Append("\n");
            sb.Append("  redeployType: ").Append(RedeployType).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AcceptScheduledEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AcceptScheduledEventResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Catalog != input.Catalog) return false;
            if (this.Type != input.Type) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.State != input.State) return false;
            if (this.InstanceType != input.InstanceType) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.PoolDisplayName != input.PoolDisplayName || (this.PoolDisplayName != null && !this.PoolDisplayName.Equals(input.PoolDisplayName))) return false;
            if (this.PublishTime != input.PublishTime || (this.PublishTime != null && !this.PublishTime.Equals(input.PublishTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.ProbeMsg != input.ProbeMsg || (this.ProbeMsg != null && !this.ProbeMsg.Equals(input.ProbeMsg))) return false;
            if (this.RedeployType != input.RedeployType || (this.RedeployType != null && input.RedeployType != null && !this.RedeployType.SequenceEqual(input.RedeployType))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.PoolDisplayName != null) hashCode = hashCode * 59 + this.PoolDisplayName.GetHashCode();
                if (this.PublishTime != null) hashCode = hashCode * 59 + this.PublishTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.ProbeMsg != null) hashCode = hashCode * 59 + this.ProbeMsg.GetHashCode();
                if (this.RedeployType != null) hashCode = hashCode * 59 + this.RedeployType.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
