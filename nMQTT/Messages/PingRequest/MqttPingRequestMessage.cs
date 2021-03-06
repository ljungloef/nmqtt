/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://wiki.github.com/markallanson/nmqtt
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System.Text;

namespace Nmqtt
{
    /// <summary>
    /// Implementation of an MQTT Ping Request Message.
    /// </summary>
    internal sealed class MqttPingRequestMessage : MqttMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MqttPublishMessage"/> class.
        /// </summary>
        /// <remarks>
        /// Only called via the MqttMessage.Create operation during processing of an Mqtt message stream.
        /// </remarks>
        public MqttPingRequestMessage()
        {
            this.Header = new MqttHeader().AsType(MqttMessageType.PingRequest);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MqttConnectMessage"/> class.
        /// </summary>
        /// <param name="header">The message header.</param>
        internal MqttPingRequestMessage(MqttHeader header)
        {
            this.Header = header;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
