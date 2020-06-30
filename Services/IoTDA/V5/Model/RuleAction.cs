using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 规则动作结构体
    /// </summary>
    public class RuleAction 
    {

        /// <summary>
        /// 规则动作的类型，取值范围： - DEVICE_CMD：下发设备命令消息类型。 - SMN_FORWARDING：发送SMN消息类型。 - DEVICE_ALARM：上报设备告警消息类型。当选择该类型时，condition中必须有DEVICE_DATA条件类型。该类型动作只能唯一。 - DIS_FORWARDING：转发DIS服务消息类型。 - OBS_FORWARDING：转发OBS服务消息类型。 - ROMA_FORWARDING：转发ROMA服务消息类型。 - IoTA_FORWARDING：转发IoTA服务消息类型。 - KAFKA_FORWARDING：转发kafka消息类型。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 附加信息，在默认规则执行结果中附加额外内容，仅设备属性和消息类型数据转发规则支持，取值范围：PRODUCT_ID
        /// </summary>
        [JsonProperty("addition", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Addition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smn_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionSmnForwarding SmnForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_alarm", NullValueHandling = NullValueHandling.Ignore)]
        public ActionDeviceAlarm DeviceAlarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_command", NullValueHandling = NullValueHandling.Ignore)]
        public ActionDeviceCommand DeviceCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dis_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionDisForwarding DisForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionObsForwarding ObsForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("roma_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionRomaForwarding RomaForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iota_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionIoTAForwarding IotaForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kafka_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionKafkaForwarding KafkaForwarding { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAction {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  addition: ").Append(Addition).Append("\n");
            sb.Append("  smnForwarding: ").Append(SmnForwarding).Append("\n");
            sb.Append("  deviceAlarm: ").Append(DeviceAlarm).Append("\n");
            sb.Append("  deviceCommand: ").Append(DeviceCommand).Append("\n");
            sb.Append("  disForwarding: ").Append(DisForwarding).Append("\n");
            sb.Append("  obsForwarding: ").Append(ObsForwarding).Append("\n");
            sb.Append("  romaForwarding: ").Append(RomaForwarding).Append("\n");
            sb.Append("  iotaForwarding: ").Append(IotaForwarding).Append("\n");
            sb.Append("  kafkaForwarding: ").Append(KafkaForwarding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Addition == input.Addition ||
                    this.Addition != null &&
                    input.Addition != null &&
                    this.Addition.SequenceEqual(input.Addition)
                ) && 
                (
                    this.SmnForwarding == input.SmnForwarding ||
                    (this.SmnForwarding != null &&
                    this.SmnForwarding.Equals(input.SmnForwarding))
                ) && 
                (
                    this.DeviceAlarm == input.DeviceAlarm ||
                    (this.DeviceAlarm != null &&
                    this.DeviceAlarm.Equals(input.DeviceAlarm))
                ) && 
                (
                    this.DeviceCommand == input.DeviceCommand ||
                    (this.DeviceCommand != null &&
                    this.DeviceCommand.Equals(input.DeviceCommand))
                ) && 
                (
                    this.DisForwarding == input.DisForwarding ||
                    (this.DisForwarding != null &&
                    this.DisForwarding.Equals(input.DisForwarding))
                ) && 
                (
                    this.ObsForwarding == input.ObsForwarding ||
                    (this.ObsForwarding != null &&
                    this.ObsForwarding.Equals(input.ObsForwarding))
                ) && 
                (
                    this.RomaForwarding == input.RomaForwarding ||
                    (this.RomaForwarding != null &&
                    this.RomaForwarding.Equals(input.RomaForwarding))
                ) && 
                (
                    this.IotaForwarding == input.IotaForwarding ||
                    (this.IotaForwarding != null &&
                    this.IotaForwarding.Equals(input.IotaForwarding))
                ) && 
                (
                    this.KafkaForwarding == input.KafkaForwarding ||
                    (this.KafkaForwarding != null &&
                    this.KafkaForwarding.Equals(input.KafkaForwarding))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Addition != null)
                    hashCode = hashCode * 59 + this.Addition.GetHashCode();
                if (this.SmnForwarding != null)
                    hashCode = hashCode * 59 + this.SmnForwarding.GetHashCode();
                if (this.DeviceAlarm != null)
                    hashCode = hashCode * 59 + this.DeviceAlarm.GetHashCode();
                if (this.DeviceCommand != null)
                    hashCode = hashCode * 59 + this.DeviceCommand.GetHashCode();
                if (this.DisForwarding != null)
                    hashCode = hashCode * 59 + this.DisForwarding.GetHashCode();
                if (this.ObsForwarding != null)
                    hashCode = hashCode * 59 + this.ObsForwarding.GetHashCode();
                if (this.RomaForwarding != null)
                    hashCode = hashCode * 59 + this.RomaForwarding.GetHashCode();
                if (this.IotaForwarding != null)
                    hashCode = hashCode * 59 + this.IotaForwarding.GetHashCode();
                if (this.KafkaForwarding != null)
                    hashCode = hashCode * 59 + this.KafkaForwarding.GetHashCode();
                return hashCode;
            }
        }
    }
}
