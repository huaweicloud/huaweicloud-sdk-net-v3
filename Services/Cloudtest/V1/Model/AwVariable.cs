using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AwVariable 
    {
        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        /// <value>响应提取时要使用什么方法处理参数</value>
        [JsonConverter(typeof(EnumClassConverter<FunctionTypeEnum>))]
        public class FunctionTypeEnum
        {
            /// <summary>
            /// Enum REGEX for value: REGEX
            /// </summary>
            public static readonly FunctionTypeEnum REGEX = new FunctionTypeEnum("REGEX");

            /// <summary>
            /// Enum SUBSTRING for value: SUBSTRING
            /// </summary>
            public static readonly FunctionTypeEnum SUBSTRING = new FunctionTypeEnum("SUBSTRING");

            private static readonly Dictionary<string, FunctionTypeEnum> StaticFields =
            new Dictionary<string, FunctionTypeEnum>()
            {
                { "REGEX", REGEX },
                { "SUBSTRING", SUBSTRING },
            };

            private string _value;

            public FunctionTypeEnum()
            {

            }

            public FunctionTypeEnum(string value)
            {
                _value = value;
            }

            public static FunctionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FunctionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FunctionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FunctionTypeEnum a, FunctionTypeEnum b)
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

            public static bool operator !=(FunctionTypeEnum a, FunctionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 节点顺序
        /// </summary>
        [JsonProperty("by_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ByOrder { get; set; }

        /// <summary>
        /// 当前人员权限
        /// </summary>
        [JsonProperty("currentPermission", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPermission { get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 动态参数名称
        /// </summary>
        [JsonProperty("dynamicParam", NullValueHandling = NullValueHandling.Ignore)]
        public string DynamicParam { get; set; }

        /// <summary>
        /// 动态参数标志,默认为false:true代表动态参数；false代表非动态参数
        /// </summary>
        [JsonProperty("dynamicParamFlag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicParamFlag { get; set; }

        /// <summary>
        /// 变量参数（[]:空参、[a]:一参，[a,b]:两参）
        /// </summary>
        [JsonProperty("functionParams", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionParams { get; set; }

        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        [JsonProperty("function_arg", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionArg { get; set; }

        /// <summary>
        /// 响应提取时要使用什么方法处理参数
        /// </summary>
        [JsonProperty("function_type", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionTypeEnum FunctionType { get; set; }
        /// <summary>
        /// 是否是敏感字段
        /// </summary>
        [JsonProperty("isSensitiveInfo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitiveInfo { get; set; }

        /// <summary>
        /// 敏感字段是否被修改，不敏感字段不关注此值
        /// </summary>
        [JsonProperty("isSensitiveModified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitiveModified { get; set; }

        /// <summary>
        /// 是否是组合aw的输出参数，只有组合aw下awInstance的aw变量有该字段
        /// </summary>
        [JsonProperty("is_out_put", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOutPut { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 0/null-变量节点;1-目录节点
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeType { get; set; }

        /// <summary>
        /// 旧名称
        /// </summary>
        [JsonProperty("oldName", NullValueHandling = NullValueHandling.Ignore)]
        public string OldName { get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [JsonProperty("parent_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        /// <summary>
        /// 内置函数枚举
        /// </summary>
        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }

        /// <summary>
        /// 敏感参数设置时间
        /// </summary>
        [JsonProperty("sensitiveInfoSetterTime", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveInfoSetterTime { get; set; }

        /// <summary>
        /// 敏感参数设置者名称
        /// </summary>
        [JsonProperty("sensitiveInfoSetterUser", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveInfoSetterUser { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 变量类型（0：text，10-16：7个内置函数）
        /// </summary>
        [JsonProperty("variableType", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariableType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AwVariable {\n");
            sb.Append("  byOrder: ").Append(ByOrder).Append("\n");
            sb.Append("  currentPermission: ").Append(CurrentPermission).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dynamicParam: ").Append(DynamicParam).Append("\n");
            sb.Append("  dynamicParamFlag: ").Append(DynamicParamFlag).Append("\n");
            sb.Append("  functionParams: ").Append(FunctionParams).Append("\n");
            sb.Append("  functionArg: ").Append(FunctionArg).Append("\n");
            sb.Append("  functionType: ").Append(FunctionType).Append("\n");
            sb.Append("  isSensitiveInfo: ").Append(IsSensitiveInfo).Append("\n");
            sb.Append("  isSensitiveModified: ").Append(IsSensitiveModified).Append("\n");
            sb.Append("  isOutPut: ").Append(IsOutPut).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  oldName: ").Append(OldName).Append("\n");
            sb.Append("  parentNodeId: ").Append(ParentNodeId).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  regex: ").Append(Regex).Append("\n");
            sb.Append("  sensitiveInfoSetterTime: ").Append(SensitiveInfoSetterTime).Append("\n");
            sb.Append("  sensitiveInfoSetterUser: ").Append(SensitiveInfoSetterUser).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  variableType: ").Append(VariableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AwVariable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AwVariable input)
        {
            if (input == null) return false;
            if (this.ByOrder != input.ByOrder || (this.ByOrder != null && !this.ByOrder.Equals(input.ByOrder))) return false;
            if (this.CurrentPermission != input.CurrentPermission || (this.CurrentPermission != null && !this.CurrentPermission.Equals(input.CurrentPermission))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DynamicParam != input.DynamicParam || (this.DynamicParam != null && !this.DynamicParam.Equals(input.DynamicParam))) return false;
            if (this.DynamicParamFlag != input.DynamicParamFlag || (this.DynamicParamFlag != null && !this.DynamicParamFlag.Equals(input.DynamicParamFlag))) return false;
            if (this.FunctionParams != input.FunctionParams || (this.FunctionParams != null && !this.FunctionParams.Equals(input.FunctionParams))) return false;
            if (this.FunctionArg != input.FunctionArg || (this.FunctionArg != null && !this.FunctionArg.Equals(input.FunctionArg))) return false;
            if (this.FunctionType != input.FunctionType) return false;
            if (this.IsSensitiveInfo != input.IsSensitiveInfo || (this.IsSensitiveInfo != null && !this.IsSensitiveInfo.Equals(input.IsSensitiveInfo))) return false;
            if (this.IsSensitiveModified != input.IsSensitiveModified || (this.IsSensitiveModified != null && !this.IsSensitiveModified.Equals(input.IsSensitiveModified))) return false;
            if (this.IsOutPut != input.IsOutPut || (this.IsOutPut != null && !this.IsOutPut.Equals(input.IsOutPut))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.OldName != input.OldName || (this.OldName != null && !this.OldName.Equals(input.OldName))) return false;
            if (this.ParentNodeId != input.ParentNodeId || (this.ParentNodeId != null && !this.ParentNodeId.Equals(input.ParentNodeId))) return false;
            if (this.Property != input.Property || (this.Property != null && !this.Property.Equals(input.Property))) return false;
            if (this.Regex != input.Regex || (this.Regex != null && !this.Regex.Equals(input.Regex))) return false;
            if (this.SensitiveInfoSetterTime != input.SensitiveInfoSetterTime || (this.SensitiveInfoSetterTime != null && !this.SensitiveInfoSetterTime.Equals(input.SensitiveInfoSetterTime))) return false;
            if (this.SensitiveInfoSetterUser != input.SensitiveInfoSetterUser || (this.SensitiveInfoSetterUser != null && !this.SensitiveInfoSetterUser.Equals(input.SensitiveInfoSetterUser))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.VariableType != input.VariableType || (this.VariableType != null && !this.VariableType.Equals(input.VariableType))) return false;

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
                if (this.ByOrder != null) hashCode = hashCode * 59 + this.ByOrder.GetHashCode();
                if (this.CurrentPermission != null) hashCode = hashCode * 59 + this.CurrentPermission.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DynamicParam != null) hashCode = hashCode * 59 + this.DynamicParam.GetHashCode();
                if (this.DynamicParamFlag != null) hashCode = hashCode * 59 + this.DynamicParamFlag.GetHashCode();
                if (this.FunctionParams != null) hashCode = hashCode * 59 + this.FunctionParams.GetHashCode();
                if (this.FunctionArg != null) hashCode = hashCode * 59 + this.FunctionArg.GetHashCode();
                hashCode = hashCode * 59 + this.FunctionType.GetHashCode();
                if (this.IsSensitiveInfo != null) hashCode = hashCode * 59 + this.IsSensitiveInfo.GetHashCode();
                if (this.IsSensitiveModified != null) hashCode = hashCode * 59 + this.IsSensitiveModified.GetHashCode();
                if (this.IsOutPut != null) hashCode = hashCode * 59 + this.IsOutPut.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.OldName != null) hashCode = hashCode * 59 + this.OldName.GetHashCode();
                if (this.ParentNodeId != null) hashCode = hashCode * 59 + this.ParentNodeId.GetHashCode();
                if (this.Property != null) hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Regex != null) hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.SensitiveInfoSetterTime != null) hashCode = hashCode * 59 + this.SensitiveInfoSetterTime.GetHashCode();
                if (this.SensitiveInfoSetterUser != null) hashCode = hashCode * 59 + this.SensitiveInfoSetterUser.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VariableType != null) hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
