// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using BarbezDotEu.MicroBlog.Enums;
using System;
using System.Collections.Generic;

namespace BarbezDotEu.MicroBlog.DTO
{
    /// <summary>
    /// Implements a flatter, "ironed" version of a user on a microblog hosting platform where most (if not all) relevant properties are immediately in the object.
    /// </summary>
    public class MicroBlogEntry
    {
        public MicroBlogEntry(string authorId, string conversationId, DateTime createdAt, string tweetId, string language, bool possiblySensitive, string replySettings, string source, string text, string mediaKeys, long likeCount, long quoteCount, long replyCount, long retweetCount, string cashTags, string hashTags, string mentions, HashSet<string> urls, string annotations, string contextAnnotations, MicroBlogHost microBlogHost)
        {
            AuthorId = authorId;
            ConversationId = conversationId;
            CreatedAt = createdAt;
            TweetId = tweetId;
            Language = language;
            PossiblySensitive = possiblySensitive;
            ReplySettings = replySettings;
            Source = source;
            Text = text;
            MediaKeys = mediaKeys;
            LikeCount = likeCount;
            QuoteCount = quoteCount;
            ReplyCount = replyCount;
            RetweetCount = retweetCount;
            CashTags = cashTags;
            HashTags = hashTags;
            Mentions = mentions;
            Urls = urls;
            Annotations = annotations;
            ContextAnnotations = contextAnnotations;
            MicroBlogHost = microBlogHost;
        }

        public string AuthorId { get; }
        public string ConversationId { get; }
        public DateTime CreatedAt { get; }
        public string TweetId { get; }
        public string Language { get; }
        public bool PossiblySensitive { get; }
        public string ReplySettings { get; }
        public string Source { get; }
        public string Text { get; }
        public string MediaKeys { get; }
        public long LikeCount { get; }
        public long QuoteCount { get; }
        public long ReplyCount { get; }
        public long RetweetCount { get; }
        public string CashTags { get; }
        public string HashTags { get; }
        public string Mentions { get; }
        public HashSet<string> Urls { get; }
        public string Annotations { get; }
        public string ContextAnnotations { get; }
        public MicroBlogHost MicroBlogHost { get; }
        public bool IsInEnglish => this.Language == "en" || this.Language == "ca";
        public bool ContainsCashTag => !string.IsNullOrWhiteSpace(this.CashTags);
    }
}
