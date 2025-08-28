using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 中心网络策略变化。
    /// </summary>
    public class CentralNetworkElementChange 
    {
        /// <summary>
        /// 实例状态。 - CreateCentralNetworkPlane: 新增中心网络平面 - DeleteCentralNetworkPlane: 移除中心网络平面 - UpdateCentralNetworkPlane: 更新中心网络平面 - CreateCentralNetworkErInstance: 新增中心网络ER实例 - DeleteCentralNetworkErInstance: 移除中心网络ER实例 - CreateCentralNetworkErConnection: 新增中心网络ER连接 - DeleteCentralNetworkErConnection: 移除中心网络ER连接 - CreateCentralNetworkErTable: 新增中心网络ER路由表 - DeleteCentralNetworkErTable: 移除中心网络ER路由表 - SwitchCentralNetworkErTable: 切换中心网络ER路由表
        /// </summary>
        /// <value>实例状态。 - CreateCentralNetworkPlane: 新增中心网络平面 - DeleteCentralNetworkPlane: 移除中心网络平面 - UpdateCentralNetworkPlane: 更新中心网络平面 - CreateCentralNetworkErInstance: 新增中心网络ER实例 - DeleteCentralNetworkErInstance: 移除中心网络ER实例 - CreateCentralNetworkErConnection: 新增中心网络ER连接 - DeleteCentralNetworkErConnection: 移除中心网络ER连接 - CreateCentralNetworkErTable: 新增中心网络ER路由表 - DeleteCentralNetworkErTable: 移除中心网络ER路由表 - SwitchCentralNetworkErTable: 切换中心网络ER路由表</value>
        [JsonConverter(typeof(EnumClassConverter<OperationIdEnum>))]
        public class OperationIdEnum
        {
            /// <summary>
            /// Enum CREATECENTRALNETWORKPLANE for value: CreateCentralNetworkPlane
            /// </summary>
            public static readonly OperationIdEnum CREATECENTRALNETWORKPLANE = new OperationIdEnum("CreateCentralNetworkPlane");

            /// <summary>
            /// Enum DELETECENTRALNETWORKPLANE for value: DeleteCentralNetworkPlane
            /// </summary>
            public static readonly OperationIdEnum DELETECENTRALNETWORKPLANE = new OperationIdEnum("DeleteCentralNetworkPlane");

            /// <summary>
            /// Enum UPDATECENTRALNETWORKPLANE for value: UpdateCentralNetworkPlane
            /// </summary>
            public static readonly OperationIdEnum UPDATECENTRALNETWORKPLANE = new OperationIdEnum("UpdateCentralNetworkPlane");

            /// <summary>
            /// Enum CREATECENTRALNETWORKERINSTANCE for value: CreateCentralNetworkErInstance
            /// </summary>
            public static readonly OperationIdEnum CREATECENTRALNETWORKERINSTANCE = new OperationIdEnum("CreateCentralNetworkErInstance");

            /// <summary>
            /// Enum DELETECENTRALNETWORKERINSTANCE for value: DeleteCentralNetworkErInstance
            /// </summary>
            public static readonly OperationIdEnum DELETECENTRALNETWORKERINSTANCE = new OperationIdEnum("DeleteCentralNetworkErInstance");

            /// <summary>
            /// Enum CREATECENTRALNETWORKERCONNECTION for value: CreateCentralNetworkErConnection
            /// </summary>
            public static readonly OperationIdEnum CREATECENTRALNETWORKERCONNECTION = new OperationIdEnum("CreateCentralNetworkErConnection");

            /// <summary>
            /// Enum DELETECENTRALNETWORKERCONNECTION for value: DeleteCentralNetworkErConnection
            /// </summary>
            public static readonly OperationIdEnum DELETECENTRALNETWORKERCONNECTION = new OperationIdEnum("DeleteCentralNetworkErConnection");

            /// <summary>
            /// Enum CREATECENTRALNETWORKERTABLE for value: CreateCentralNetworkErTable
            /// </summary>
            public static readonly OperationIdEnum CREATECENTRALNETWORKERTABLE = new OperationIdEnum("CreateCentralNetworkErTable");

            /// <summary>
            /// Enum DELETECENTRALNETWORKERTABLE for value: DeleteCentralNetworkErTable
            /// </summary>
            public static readonly OperationIdEnum DELETECENTRALNETWORKERTABLE = new OperationIdEnum("DeleteCentralNetworkErTable");

            /// <summary>
            /// Enum SWITCHCENTRALNETWORKERTABLE for value: SwitchCentralNetworkErTable
            /// </summary>
            public static readonly OperationIdEnum SWITCHCENTRALNETWORKERTABLE = new OperationIdEnum("SwitchCentralNetworkErTable");

            private static readonly Dictionary<string, OperationIdEnum> StaticFields =
            new Dictionary<string, OperationIdEnum>()
            {
                { "CreateCentralNetworkPlane", CREATECENTRALNETWORKPLANE },
                { "DeleteCentralNetworkPlane", DELETECENTRALNETWORKPLANE },
                { "UpdateCentralNetworkPlane", UPDATECENTRALNETWORKPLANE },
                { "CreateCentralNetworkErInstance", CREATECENTRALNETWORKERINSTANCE },
                { "DeleteCentralNetworkErInstance", DELETECENTRALNETWORKERINSTANCE },
                { "CreateCentralNetworkErConnection", CREATECENTRALNETWORKERCONNECTION },
                { "DeleteCentralNetworkErConnection", DELETECENTRALNETWORKERCONNECTION },
                { "CreateCentralNetworkErTable", CREATECENTRALNETWORKERTABLE },
                { "DeleteCentralNetworkErTable", DELETECENTRALNETWORKERTABLE },
                { "SwitchCentralNetworkErTable", SWITCHCENTRALNETWORKERTABLE },
            };

            private string _value;

            public OperationIdEnum()
            {

            }

            public OperationIdEnum(string value)
            {
                _value = value;
            }

            public static OperationIdEnum FromValue(string value)
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

                if (this.Equals(obj as OperationIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationIdEnum a, OperationIdEnum b)
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

            public static bool operator !=(OperationIdEnum a, OperationIdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例状态。 - CreateCentralNetworkPlane: 新增中心网络平面 - DeleteCentralNetworkPlane: 移除中心网络平面 - UpdateCentralNetworkPlane: 更新中心网络平面 - CreateCentralNetworkErInstance: 新增中心网络ER实例 - DeleteCentralNetworkErInstance: 移除中心网络ER实例 - CreateCentralNetworkErConnection: 新增中心网络ER连接 - DeleteCentralNetworkErConnection: 移除中心网络ER连接 - CreateCentralNetworkErTable: 新增中心网络ER路由表 - DeleteCentralNetworkErTable: 移除中心网络ER路由表 - SwitchCentralNetworkErTable: 切换中心网络ER路由表
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public OperationIdEnum OperationId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkElementChange {\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkElementChange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkElementChange input)
        {
            if (input == null) return false;
            if (this.OperationId != input.OperationId) return false;

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
                hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
