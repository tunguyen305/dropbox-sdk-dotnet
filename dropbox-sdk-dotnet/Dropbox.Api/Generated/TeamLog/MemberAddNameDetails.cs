// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added team member name.</para>
    /// </summary>
    public class MemberAddNameDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberAddNameDetails> Encoder = new MemberAddNameDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberAddNameDetails> Decoder = new MemberAddNameDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddNameDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New user's name.</param>
        public MemberAddNameDetails(UserNameLogInfo newValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddNameDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberAddNameDetails()
        {
        }

        /// <summary>
        /// <para>New user's name.</para>
        /// </summary>
        public UserNameLogInfo NewValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberAddNameDetails" />.</para>
        /// </summary>
        private class MemberAddNameDetailsEncoder : enc.StructEncoder<MemberAddNameDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberAddNameDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.UserNameLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberAddNameDetails" />.</para>
        /// </summary>
        private class MemberAddNameDetailsDecoder : enc.StructDecoder<MemberAddNameDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberAddNameDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberAddNameDetails Create()
            {
                return new MemberAddNameDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberAddNameDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.UserNameLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
