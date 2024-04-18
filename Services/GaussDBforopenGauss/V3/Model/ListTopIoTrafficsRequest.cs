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
    public class ListTopIoTrafficsRequest 
    {
        /// <summary>
        /// TOP IO排序条件
        /// </summary>
        /// <value>TOP IO排序条件</value>
        [JsonConverter(typeof(EnumClassConverter<SortConditionEnum>))]
        public class SortConditionEnum
        {
            /// <summary>
            /// Enum READ for value: read
            /// </summary>
            public static readonly SortConditionEnum READ = new SortConditionEnum("read");

            /// <summary>
            /// Enum WRITE for value: write
            /// </summary>
            public static readonly SortConditionEnum WRITE = new SortConditionEnum("write");

            private static readonly Dictionary<string, SortConditionEnum> StaticFields =
            new Dictionary<string, SortConditionEnum>()
            {
                { "read", READ },
                { "write", WRITE },
            };

            private string _value;

            public SortConditionEnum()
            {

            }

            public SortConditionEnum(string value)
            {
                _value = value;
            }

            public static SortConditionEnum FromValue(string value)
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

                if (this.Equals(obj as SortConditionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortConditionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortConditionEnum a, SortConditionEnum b)
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

            public static bool operator !=(SortConditionEnum a, SortConditionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID，严格匹配UUID规则。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 节点ID。节点应为CN或者非日志角色的DN节点，并且节点状态为正常。
        /// </summary>
        [SDKProperty("node_id", IsQuery = true)]
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 组件ID。组件应为CN或者非日志角色的DN组件。 DN：Data Node，和CN对应的概念。负责实际执行表数据的存储、查询操作。 CN：Coordinator Node，负责数据库系统元数据存储、查询任务的分解和部分执行，以及将DN中查询结果汇聚在一起。
        /// </summary>
        [SDKProperty("component_id", IsQuery = true)]
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 期望查询数据库进程下TOP IO线程数（默认值为20）。接口返回TOP IO线程与会话信息关联后的结果，数量最大不超过该值。
        /// </summary>
        [SDKProperty("top_io_num", IsQuery = true)]
        [JsonProperty("top_io_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopIoNum { get; set; }

        /// <summary>
        /// TOP IO排序条件
        /// </summary>
        [SDKProperty("sort_condition", IsQuery = true)]
        [JsonProperty("sort_condition", NullValueHandling = NullValueHandling.Ignore)]
        public SortConditionEnum SortCondition { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopIoTrafficsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  topIoNum: ").Append(TopIoNum).Append("\n");
            sb.Append("  sortCondition: ").Append(SortCondition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopIoTrafficsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopIoTrafficsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.TopIoNum == input.TopIoNum ||
                    (this.TopIoNum != null &&
                    this.TopIoNum.Equals(input.TopIoNum))
                ) && 
                (
                    this.SortCondition == input.SortCondition ||
                    (this.SortCondition != null &&
                    this.SortCondition.Equals(input.SortCondition))
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
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.TopIoNum != null)
                    hashCode = hashCode * 59 + this.TopIoNum.GetHashCode();
                if (this.SortCondition != null)
                    hashCode = hashCode * 59 + this.SortCondition.GetHashCode();
                return hashCode;
            }
        }
    }
}
