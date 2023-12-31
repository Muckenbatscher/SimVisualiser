﻿using HttpPost.Interfaces;
using HttpPost.Messages.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPost.EndPoints.Initialization
{
    public class GameRegistrationEndpoint : BaseEndpoint, IEndpoint<GameRegistrationMessage>, IDisposable
    {
        private static string _endPoint = "game_metadata";
        public GameRegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(GameRegistrationMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }

        public bool PostMessage(GameRegistrationMessage message)
        {
            return SerializeAndPostMessage(message);
        }
    }
}
