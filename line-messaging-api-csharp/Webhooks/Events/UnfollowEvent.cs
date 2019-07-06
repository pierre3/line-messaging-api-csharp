﻿namespace LineDC.Messaging.Webhooks.Events
{
    /// <summary>
    /// Event object for when your account is blocked.
    /// </summary>
    public class UnfollowEvent : WebhookEvent
    {
        public UnfollowEvent(WebhookEventSource source, long timestamp)
            : base(WebhookEventType.Unfollow, source, timestamp)
        {
        }
    }
}
