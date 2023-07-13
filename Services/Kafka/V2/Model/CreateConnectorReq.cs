using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateConnectorReq 
    {
        /// <summary>
        /// 部署connector的规格，基准带宽，表示单位时间内传送的最大数据量，单位Byte/秒。  取值范围：   - 100MB   - 300MB   - 600MB   - 1200MB  可以不填，则默认跟当前实例的规格是一致。  第一阶段实现先不填，保持和当前实例规格一致，后面再扩展可以选择不同的规格。
        /// </summary>
        /// <value>部署connector的规格，基准带宽，表示单位时间内传送的最大数据量，单位Byte/秒。  取值范围：   - 100MB   - 300MB   - 600MB   - 1200MB  可以不填，则默认跟当前实例的规格是一致。  第一阶段实现先不填，保持和当前实例规格一致，后面再扩展可以选择不同的规格。</value>
        [JsonConverter(typeof(EnumClassConverter<SpecificationEnum>))]
        public class SpecificationEnum
        {
            /// <summary>
            /// Enum _100MB for value: 100MB
            /// </summary>
            public static readonly SpecificationEnum _100MB = new SpecificationEnum("100MB");

            /// <summary>
            /// Enum _300MB for value: 300MB
            /// </summary>
            public static readonly SpecificationEnum _300MB = new SpecificationEnum("300MB");

            /// <summary>
            /// Enum _600MB for value: 600MB
            /// </summary>
            public static readonly SpecificationEnum _600MB = new SpecificationEnum("600MB");

            /// <summary>
            /// Enum _1200MB for value: 1200MB
            /// </summary>
            public static readonly SpecificationEnum _1200MB = new SpecificationEnum("1200MB");

            private static readonly Dictionary<string, SpecificationEnum> StaticFields =
            new Dictionary<string, SpecificationEnum>()
            {
                { "100MB", _100MB },
                { "300MB", _300MB },
                { "600MB", _600MB },
                { "1200MB", _1200MB },
            };

            private string _value;

            public SpecificationEnum()
            {

            }

            public SpecificationEnum(string value)
            {
                _value = value;
            }

            public static SpecificationEnum FromValue(string value)
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

                if (this.Equals(obj as SpecificationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecificationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecificationEnum a, SpecificationEnum b)
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

            public static bool operator !=(SpecificationEnum a, SpecificationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署connector的规格，基准带宽，表示单位时间内传送的最大数据量，单位Byte/秒。  取值范围：   - 100MB   - 300MB   - 600MB   - 1200MB  可以不填，则默认跟当前实例的规格是一致。  第一阶段实现先不填，保持和当前实例规格一致，后面再扩展可以选择不同的规格。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public SpecificationEnum Specification { get; set; }
        /// <summary>
        /// 转储节点数量。不能小于2个。 默认是2个。 
        /// </summary>
        [JsonProperty("node_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeCnt { get; set; }

        /// <summary>
        /// 转储节点规格编码。 
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConnectorReq {\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  nodeCnt: ").Append(NodeCnt).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConnectorReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConnectorReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.NodeCnt == input.NodeCnt ||
                    (this.NodeCnt != null &&
                    this.NodeCnt.Equals(input.NodeCnt))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
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
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.NodeCnt != null)
                    hashCode = hashCode * 59 + this.NodeCnt.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
