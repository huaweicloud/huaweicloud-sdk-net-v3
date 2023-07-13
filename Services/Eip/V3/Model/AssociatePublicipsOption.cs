using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociatePublicipsOption 
    {
        /// <summary>
        /// 功能说明：端口所属实例类型 取值范围：PORT、NATGW、VPN、ELB 约束：associate_instance_type和associate_instance_id都不为空时表示绑定实例 约束：associate_instance_type字段不允许为空 约束：双栈公网IP不允许修改绑定的实例
        /// </summary>
        /// <value>功能说明：端口所属实例类型 取值范围：PORT、NATGW、VPN、ELB 约束：associate_instance_type和associate_instance_id都不为空时表示绑定实例 约束：associate_instance_type字段不允许为空 约束：双栈公网IP不允许修改绑定的实例</value>
        [JsonConverter(typeof(EnumClassConverter<AssociateInstanceTypeEnum>))]
        public class AssociateInstanceTypeEnum
        {
            /// <summary>
            /// Enum PORT for value: PORT
            /// </summary>
            public static readonly AssociateInstanceTypeEnum PORT = new AssociateInstanceTypeEnum("PORT");

            /// <summary>
            /// Enum NATGW for value: NATGW
            /// </summary>
            public static readonly AssociateInstanceTypeEnum NATGW = new AssociateInstanceTypeEnum("NATGW");

            /// <summary>
            /// Enum VPN for value: VPN
            /// </summary>
            public static readonly AssociateInstanceTypeEnum VPN = new AssociateInstanceTypeEnum("VPN");

            /// <summary>
            /// Enum ELB for value: ELB
            /// </summary>
            public static readonly AssociateInstanceTypeEnum ELB = new AssociateInstanceTypeEnum("ELB");

            private static readonly Dictionary<string, AssociateInstanceTypeEnum> StaticFields =
            new Dictionary<string, AssociateInstanceTypeEnum>()
            {
                { "PORT", PORT },
                { "NATGW", NATGW },
                { "VPN", VPN },
                { "ELB", ELB },
            };

            private string _value;

            public AssociateInstanceTypeEnum()
            {

            }

            public AssociateInstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static AssociateInstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssociateInstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssociateInstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
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

            public static bool operator !=(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：端口所属实例类型 取值范围：PORT、NATGW、VPN、ELB 约束：associate_instance_type和associate_instance_id都不为空时表示绑定实例 约束：associate_instance_type字段不允许为空 约束：双栈公网IP不允许修改绑定的实例
        /// </summary>
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceTypeEnum AssociateInstanceType { get; set; }
        /// <summary>
        /// 功能说明：端口所属实例ID，例如RDS实例ID 约束：associate_instance_type和associate_instance_id都不为空时表示绑定实例； associate_instance_type和associate_instance_id都为null时解绑实例 约束：双栈公网IP不允许修改绑定的实例
        /// </summary>
        [JsonProperty("associate_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatePublicipsOption {\n");
            sb.Append("  associateInstanceType: ").Append(AssociateInstanceType).Append("\n");
            sb.Append("  associateInstanceId: ").Append(AssociateInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatePublicipsOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatePublicipsOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssociateInstanceType == input.AssociateInstanceType ||
                    (this.AssociateInstanceType != null &&
                    this.AssociateInstanceType.Equals(input.AssociateInstanceType))
                ) && 
                (
                    this.AssociateInstanceId == input.AssociateInstanceId ||
                    (this.AssociateInstanceId != null &&
                    this.AssociateInstanceId.Equals(input.AssociateInstanceId))
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
                if (this.AssociateInstanceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.AssociateInstanceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
