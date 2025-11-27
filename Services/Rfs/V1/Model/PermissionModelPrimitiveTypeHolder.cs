using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionModelPrimitiveTypeHolder 
    {
        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。
        /// </summary>
        /// <value>权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionModelEnum>))]
        public class PermissionModelEnum
        {
            /// <summary>
            /// Enum SELF_MANAGED for value: SELF_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SELF_MANAGED = new PermissionModelEnum("SELF_MANAGED");

            /// <summary>
            /// Enum SERVICE_MANAGED for value: SERVICE_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SERVICE_MANAGED = new PermissionModelEnum("SERVICE_MANAGED");

            private static readonly Dictionary<string, PermissionModelEnum> StaticFields =
            new Dictionary<string, PermissionModelEnum>()
            {
                { "SELF_MANAGED", SELF_MANAGED },
                { "SERVICE_MANAGED", SERVICE_MANAGED },
            };

            private string _value;

            public PermissionModelEnum()
            {

            }

            public PermissionModelEnum(string value)
            {
                _value = value;
            }

            public static PermissionModelEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionModelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionModelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionModelEnum a, PermissionModelEnum b)
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

            public static bool operator !=(PermissionModelEnum a, PermissionModelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。
        /// </summary>
        [JsonProperty("permission_model", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionModelEnum PermissionModel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionModelPrimitiveTypeHolder {\n");
            sb.Append("  permissionModel: ").Append(PermissionModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionModelPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionModelPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.PermissionModel != input.PermissionModel) return false;

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
                hashCode = hashCode * 59 + this.PermissionModel.GetHashCode();
                return hashCode;
            }
        }
    }
}
