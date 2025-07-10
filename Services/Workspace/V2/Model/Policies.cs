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
    /// 策略类。
    /// </summary>
    public class Policies 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("peripherals", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripherals Peripherals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesAudio Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesDisplay Display { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_and_clipboard", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboard FileAndClipboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session", NullValueHandling = NullValueHandling.Ignore)]
        public Session Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("virtual_channel", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualChannel VirtualChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("watermark", NullValueHandling = NullValueHandling.Ignore)]
        public Watermark Watermark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("keyboard_mouse", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesKeyboardMouse KeyboardMouse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("seamless", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesSeamless Seamless { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("personalized_data_mgmt", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPersonalizedDataMgmt PersonalizedDataMgmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesCustom Custom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_audit", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesRecordAudit RecordAudit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policies {\n");
            sb.Append("  peripherals: ").Append(Peripherals).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  _Client: ").Append(Client).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  fileAndClipboard: ").Append(FileAndClipboard).Append("\n");
            sb.Append("  session: ").Append(Session).Append("\n");
            sb.Append("  virtualChannel: ").Append(VirtualChannel).Append("\n");
            sb.Append("  watermark: ").Append(Watermark).Append("\n");
            sb.Append("  keyboardMouse: ").Append(KeyboardMouse).Append("\n");
            sb.Append("  seamless: ").Append(Seamless).Append("\n");
            sb.Append("  personalizedDataMgmt: ").Append(PersonalizedDataMgmt).Append("\n");
            sb.Append("  custom: ").Append(Custom).Append("\n");
            sb.Append("  recordAudit: ").Append(RecordAudit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Policies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Policies input)
        {
            if (input == null) return false;
            if (this.Peripherals != input.Peripherals || (this.Peripherals != null && !this.Peripherals.Equals(input.Peripherals))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;
            if (this.Client != input.Client || (this.Client != null && !this.Client.Equals(input.Client))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.FileAndClipboard != input.FileAndClipboard || (this.FileAndClipboard != null && !this.FileAndClipboard.Equals(input.FileAndClipboard))) return false;
            if (this.Session != input.Session || (this.Session != null && !this.Session.Equals(input.Session))) return false;
            if (this.VirtualChannel != input.VirtualChannel || (this.VirtualChannel != null && !this.VirtualChannel.Equals(input.VirtualChannel))) return false;
            if (this.Watermark != input.Watermark || (this.Watermark != null && !this.Watermark.Equals(input.Watermark))) return false;
            if (this.KeyboardMouse != input.KeyboardMouse || (this.KeyboardMouse != null && !this.KeyboardMouse.Equals(input.KeyboardMouse))) return false;
            if (this.Seamless != input.Seamless || (this.Seamless != null && !this.Seamless.Equals(input.Seamless))) return false;
            if (this.PersonalizedDataMgmt != input.PersonalizedDataMgmt || (this.PersonalizedDataMgmt != null && !this.PersonalizedDataMgmt.Equals(input.PersonalizedDataMgmt))) return false;
            if (this.Custom != input.Custom || (this.Custom != null && !this.Custom.Equals(input.Custom))) return false;
            if (this.RecordAudit != input.RecordAudit || (this.RecordAudit != null && !this.RecordAudit.Equals(input.RecordAudit))) return false;

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
                if (this.Peripherals != null) hashCode = hashCode * 59 + this.Peripherals.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Client != null) hashCode = hashCode * 59 + this.Client.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.FileAndClipboard != null) hashCode = hashCode * 59 + this.FileAndClipboard.GetHashCode();
                if (this.Session != null) hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.VirtualChannel != null) hashCode = hashCode * 59 + this.VirtualChannel.GetHashCode();
                if (this.Watermark != null) hashCode = hashCode * 59 + this.Watermark.GetHashCode();
                if (this.KeyboardMouse != null) hashCode = hashCode * 59 + this.KeyboardMouse.GetHashCode();
                if (this.Seamless != null) hashCode = hashCode * 59 + this.Seamless.GetHashCode();
                if (this.PersonalizedDataMgmt != null) hashCode = hashCode * 59 + this.PersonalizedDataMgmt.GetHashCode();
                if (this.Custom != null) hashCode = hashCode * 59 + this.Custom.GetHashCode();
                if (this.RecordAudit != null) hashCode = hashCode * 59 + this.RecordAudit.GetHashCode();
                return hashCode;
            }
        }
    }
}
