using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 拓扑树节点信息。
    /// </summary>
    public class TreeNode 
    {
        /// <summary>
        /// 节点类型。
        /// </summary>
        /// <value>节点类型。</value>
        [JsonConverter(typeof(EnumClassConverter<NodeTypeEnum>))]
        public class NodeTypeEnum
        {
            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            public static readonly NodeTypeEnum BUSINESS = new NodeTypeEnum("BUSINESS");

            /// <summary>
            /// Enum SUB_BUSINESS for value: SUB_BUSINESS
            /// </summary>
            public static readonly NodeTypeEnum SUB_BUSINESS = new NodeTypeEnum("SUB_BUSINESS");

            /// <summary>
            /// Enum APPLICATION for value: APPLICATION
            /// </summary>
            public static readonly NodeTypeEnum APPLICATION = new NodeTypeEnum("APPLICATION");

            /// <summary>
            /// Enum ENVIRONMENT for value: ENVIRONMENT
            /// </summary>
            public static readonly NodeTypeEnum ENVIRONMENT = new NodeTypeEnum("ENVIRONMENT");

            private static readonly Dictionary<string, NodeTypeEnum> StaticFields =
            new Dictionary<string, NodeTypeEnum>()
            {
                { "BUSINESS", BUSINESS },
                { "SUB_BUSINESS", SUB_BUSINESS },
                { "APPLICATION", APPLICATION },
                { "ENVIRONMENT", ENVIRONMENT },
            };

            private string _value;

            public NodeTypeEnum()
            {

            }

            public NodeTypeEnum(string value)
            {
                _value = value;
            }

            public static NodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 拓扑树节点id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 拓扑树节点的父节点。
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public string Parent { get; set; }

        /// <summary>
        /// 拓扑树节点的实际id。
        /// </summary>
        [JsonProperty("real_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealId { get; set; }

        /// <summary>
        /// 拓扑树节点名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 拓扑树节点展示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 组件id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; }

        /// <summary>
        /// 是否是管理节点。
        /// </summary>
        [JsonProperty("is_admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// 是否是根节点。
        /// </summary>
        [JsonProperty("is_root", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 节点类型。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// 区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 是否是默认的节点。
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TreeNode {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  parent: ").Append(Parent).Append("\n");
            sb.Append("  realId: ").Append(RealId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  isAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  isRoot: ").Append(IsRoot).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TreeNode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TreeNode input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Parent != input.Parent || (this.Parent != null && !this.Parent.Equals(input.Parent))) return false;
            if (this.RealId != input.RealId || (this.RealId != null && !this.RealId.Equals(input.RealId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.IsAdmin != input.IsAdmin || (this.IsAdmin != null && !this.IsAdmin.Equals(input.IsAdmin))) return false;
            if (this.IsRoot != input.IsRoot || (this.IsRoot != null && !this.IsRoot.Equals(input.IsRoot))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.NodeType != input.NodeType) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;

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
                if (this.Parent != null) hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.RealId != null) hashCode = hashCode * 59 + this.RealId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.IsAdmin != null) hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.IsRoot != null) hashCode = hashCode * 59 + this.IsRoot.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
