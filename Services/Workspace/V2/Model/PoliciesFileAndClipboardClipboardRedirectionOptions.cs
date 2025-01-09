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
    /// 剪切板重定向控制的选项。
    /// </summary>
    public class PoliciesFileAndClipboardClipboardRedirectionOptions 
    {

        /// <summary>
        /// 是否开启剪切板富文本重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("rich_text_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RichTextRedirectionEnable { get; set; }

        /// <summary>
        /// 是否开启剪切板文件重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("clipboard_file_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardFileRedirectionEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardClipboardRedirectionOptions {\n");
            sb.Append("  richTextRedirectionEnable: ").Append(RichTextRedirectionEnable).Append("\n");
            sb.Append("  clipboardFileRedirectionEnable: ").Append(ClipboardFileRedirectionEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardClipboardRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardClipboardRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.RichTextRedirectionEnable != input.RichTextRedirectionEnable || (this.RichTextRedirectionEnable != null && !this.RichTextRedirectionEnable.Equals(input.RichTextRedirectionEnable))) return false;
            if (this.ClipboardFileRedirectionEnable != input.ClipboardFileRedirectionEnable || (this.ClipboardFileRedirectionEnable != null && !this.ClipboardFileRedirectionEnable.Equals(input.ClipboardFileRedirectionEnable))) return false;

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
                if (this.RichTextRedirectionEnable != null) hashCode = hashCode * 59 + this.RichTextRedirectionEnable.GetHashCode();
                if (this.ClipboardFileRedirectionEnable != null) hashCode = hashCode * 59 + this.ClipboardFileRedirectionEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
