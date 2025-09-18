using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateBatchChangeOrderRequestBody 
    {
        /// <summary>
        /// 下单类型。  - ADD_VOLUME：增加磁盘  - EXTEND_VOLUME：扩容磁盘  - RESIZE：变更规格  - CHANGE_IMAGE：切换镜像  - ADD_SUB_RESOURCES：购买桌面协同资源  - DELETE_SUB_RESOURCES：退订桌面协同资源
        /// </summary>
        /// <value>下单类型。  - ADD_VOLUME：增加磁盘  - EXTEND_VOLUME：扩容磁盘  - RESIZE：变更规格  - CHANGE_IMAGE：切换镜像  - ADD_SUB_RESOURCES：购买桌面协同资源  - DELETE_SUB_RESOURCES：退订桌面协同资源</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ADD_VOLUME for value: ADD_VOLUME
            /// </summary>
            public static readonly TypeEnum ADD_VOLUME = new TypeEnum("ADD_VOLUME");

            /// <summary>
            /// Enum EXTEND_VOLUME for value: EXTEND_VOLUME
            /// </summary>
            public static readonly TypeEnum EXTEND_VOLUME = new TypeEnum("EXTEND_VOLUME");

            /// <summary>
            /// Enum RESIZE for value: RESIZE
            /// </summary>
            public static readonly TypeEnum RESIZE = new TypeEnum("RESIZE");

            /// <summary>
            /// Enum CHANGE_IMAGE for value: CHANGE_IMAGE
            /// </summary>
            public static readonly TypeEnum CHANGE_IMAGE = new TypeEnum("CHANGE_IMAGE");

            /// <summary>
            /// Enum ADD_SUB_RESOURCES for value: ADD_SUB_RESOURCES
            /// </summary>
            public static readonly TypeEnum ADD_SUB_RESOURCES = new TypeEnum("ADD_SUB_RESOURCES");

            /// <summary>
            /// Enum DELETE_SUB_RESOURCES for value: DELETE_SUB_RESOURCES
            /// </summary>
            public static readonly TypeEnum DELETE_SUB_RESOURCES = new TypeEnum("DELETE_SUB_RESOURCES");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ADD_VOLUME", ADD_VOLUME },
                { "EXTEND_VOLUME", EXTEND_VOLUME },
                { "RESIZE", RESIZE },
                { "CHANGE_IMAGE", CHANGE_IMAGE },
                { "ADD_SUB_RESOURCES", ADD_SUB_RESOURCES },
                { "DELETE_SUB_RESOURCES", DELETE_SUB_RESOURCES },
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
        /// 下单类型。  - ADD_VOLUME：增加磁盘  - EXTEND_VOLUME：扩容磁盘  - RESIZE：变更规格  - CHANGE_IMAGE：切换镜像  - ADD_SUB_RESOURCES：购买桌面协同资源  - DELETE_SUB_RESOURCES：退订桌面协同资源
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add_volume_param", NullValueHandling = NullValueHandling.Ignore)]
        public EstimateAddVolumeRequestBody AddVolumeParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_volume_param", NullValueHandling = NullValueHandling.Ignore)]
        public EstimateExtendVolumeRequestBody ExtendVolumeParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize_param", NullValueHandling = NullValueHandling.Ignore)]
        public CreateResizeOrderRequestBody ResizeParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("change_image_param", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChangeImageOrderRequestBody ChangeImageParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add_sub_resources_param", NullValueHandling = NullValueHandling.Ignore)]
        public EstimateAddSubResourcesRequestBody AddSubResourcesParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete_sub_resources_param", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDeleteSubResourcesOrderRequestBody DeleteSubResourcesParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBatchChangeOrderRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  addVolumeParam: ").Append(AddVolumeParam).Append("\n");
            sb.Append("  extendVolumeParam: ").Append(ExtendVolumeParam).Append("\n");
            sb.Append("  resizeParam: ").Append(ResizeParam).Append("\n");
            sb.Append("  changeImageParam: ").Append(ChangeImageParam).Append("\n");
            sb.Append("  addSubResourcesParam: ").Append(AddSubResourcesParam).Append("\n");
            sb.Append("  deleteSubResourcesParam: ").Append(DeleteSubResourcesParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBatchChangeOrderRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBatchChangeOrderRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.AddVolumeParam != input.AddVolumeParam || (this.AddVolumeParam != null && !this.AddVolumeParam.Equals(input.AddVolumeParam))) return false;
            if (this.ExtendVolumeParam != input.ExtendVolumeParam || (this.ExtendVolumeParam != null && !this.ExtendVolumeParam.Equals(input.ExtendVolumeParam))) return false;
            if (this.ResizeParam != input.ResizeParam || (this.ResizeParam != null && !this.ResizeParam.Equals(input.ResizeParam))) return false;
            if (this.ChangeImageParam != input.ChangeImageParam || (this.ChangeImageParam != null && !this.ChangeImageParam.Equals(input.ChangeImageParam))) return false;
            if (this.AddSubResourcesParam != input.AddSubResourcesParam || (this.AddSubResourcesParam != null && !this.AddSubResourcesParam.Equals(input.AddSubResourcesParam))) return false;
            if (this.DeleteSubResourcesParam != input.DeleteSubResourcesParam || (this.DeleteSubResourcesParam != null && !this.DeleteSubResourcesParam.Equals(input.DeleteSubResourcesParam))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AddVolumeParam != null) hashCode = hashCode * 59 + this.AddVolumeParam.GetHashCode();
                if (this.ExtendVolumeParam != null) hashCode = hashCode * 59 + this.ExtendVolumeParam.GetHashCode();
                if (this.ResizeParam != null) hashCode = hashCode * 59 + this.ResizeParam.GetHashCode();
                if (this.ChangeImageParam != null) hashCode = hashCode * 59 + this.ChangeImageParam.GetHashCode();
                if (this.AddSubResourcesParam != null) hashCode = hashCode * 59 + this.AddSubResourcesParam.GetHashCode();
                if (this.DeleteSubResourcesParam != null) hashCode = hashCode * 59 + this.DeleteSubResourcesParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
