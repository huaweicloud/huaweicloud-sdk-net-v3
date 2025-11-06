using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TreeDto 
    {
        /// <summary>
        /// **参数解释：** 文件结构。 **取值范围：** - commit, 子模块。 - tree, 目录。 - blob, 文件
        /// </summary>
        /// <value>**参数解释：** 文件结构。 **取值范围：** - commit, 子模块。 - tree, 目录。 - blob, 文件</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum COMMIT for value: commit
            /// </summary>
            public static readonly TypeEnum COMMIT = new TypeEnum("commit");

            /// <summary>
            /// Enum TREE for value: tree
            /// </summary>
            public static readonly TypeEnum TREE = new TypeEnum("tree");

            /// <summary>
            /// Enum BLOB for value: blob
            /// </summary>
            public static readonly TypeEnum BLOB = new TypeEnum("blob");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "commit", COMMIT },
                { "tree", TREE },
                { "blob", BLOB },
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
        /// **参数解释：** 提交ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 文件名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 文件结构。 **取值范围：** - commit, 子模块。 - tree, 目录。 - blob, 文件
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 文件路径。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 当前所在目录层级。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// **参数解释：** 是否下拉。 **取值范围：** - false, 不下拉。 - true, 下拉
        /// </summary>
        [JsonProperty("isShownDropDown", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShownDropDown { get; set; }

        /// <summary>
        /// **参数解释：** 是否折叠。 **取值范围：** - false, 不折叠。 - true, 折叠。
        /// </summary>
        [JsonProperty("folder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Folder { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<TreeDto> Children { get; set; }

        /// <summary>
        /// **参数解释：** 子模块连接。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("submodule_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleLink { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TreeDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  isShownDropDown: ").Append(IsShownDropDown).Append("\n");
            sb.Append("  folder: ").Append(Folder).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  submoduleLink: ").Append(SubmoduleLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TreeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TreeDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.IsShownDropDown != input.IsShownDropDown || (this.IsShownDropDown != null && !this.IsShownDropDown.Equals(input.IsShownDropDown))) return false;
            if (this.Folder != input.Folder || (this.Folder != null && !this.Folder.Equals(input.Folder))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.SubmoduleLink != input.SubmoduleLink || (this.SubmoduleLink != null && !this.SubmoduleLink.Equals(input.SubmoduleLink))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.IsShownDropDown != null) hashCode = hashCode * 59 + this.IsShownDropDown.GetHashCode();
                if (this.Folder != null) hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.SubmoduleLink != null) hashCode = hashCode * 59 + this.SubmoduleLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
