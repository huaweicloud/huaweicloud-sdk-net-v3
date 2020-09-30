using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 策略执行具体动作
    /// </summary>
    public class ScalingPolicyAction 
    {
        /// <summary>
        /// 操作选项。ADD：添加实例。REMOVE/REDUCE：移除实例。SET：设置实例数为
        /// </summary>
        /// <value>操作选项。ADD：添加实例。REMOVE/REDUCE：移除实例。SET：设置实例数为</value>
        [JsonConverter(typeof(EnumClassConverter<OperationEnum>))]
        public class OperationEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly OperationEnum ADD = new OperationEnum("ADD");

            /// <summary>
            /// Enum REMOVE for value: REMOVE
            /// </summary>
            public static readonly OperationEnum REMOVE = new OperationEnum("REMOVE");

            /// <summary>
            /// Enum REDUCE for value: REDUCE
            /// </summary>
            public static readonly OperationEnum REDUCE = new OperationEnum("REDUCE");

            /// <summary>
            /// Enum SET for value: SET
            /// </summary>
            public static readonly OperationEnum SET = new OperationEnum("SET");

            private static readonly Dictionary<string, OperationEnum> StaticFields =
            new Dictionary<string, OperationEnum>()
            {
                { "ADD", ADD },
                { "REMOVE", REMOVE },
                { "REDUCE", REDUCE },
                { "SET", SET },
            };

            private string Value;

            private OperationEnum(string value)
            {
                this.Value = value;
            }

            public static OperationEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as OperationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OperationEnum a, OperationEnum b)
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

            public static bool operator !=(OperationEnum a, OperationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作选项。ADD：添加实例。REMOVE/REDUCE：移除实例。SET：设置实例数为
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public OperationEnum Operation { get; set; }
        /// <summary>
        /// 操作实例个数，默认为1。配置参数时，instance_number和instance_percentage参数只能选其中一个进行配置。
        /// </summary>
        [JsonProperty("instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNumber { get; set; }

        /// <summary>
        /// 操作实例百分比，将当前组容量增加、减少或设置为指定的百分比。当instance_number和instance_percentage参数均无配置时，则操作实例个数为1。配置参数时，instance_number和instance_percentage参数只能选其中一个进行配置。
        /// </summary>
        [JsonProperty("instance_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstancePercentage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicyAction {\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  instanceNumber: ").Append(InstanceNumber).Append("\n");
            sb.Append("  instancePercentage: ").Append(InstancePercentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicyAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicyAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.InstanceNumber == input.InstanceNumber ||
                    (this.InstanceNumber != null &&
                    this.InstanceNumber.Equals(input.InstanceNumber))
                ) && 
                (
                    this.InstancePercentage == input.InstancePercentage ||
                    (this.InstancePercentage != null &&
                    this.InstancePercentage.Equals(input.InstancePercentage))
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
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.InstanceNumber != null)
                    hashCode = hashCode * 59 + this.InstanceNumber.GetHashCode();
                if (this.InstancePercentage != null)
                    hashCode = hashCode * 59 + this.InstancePercentage.GetHashCode();
                return hashCode;
            }
        }
    }
}
