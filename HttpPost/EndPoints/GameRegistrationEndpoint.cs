﻿using HttpPost.Interfaces;
using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPost.EndPoints
{
    public class GameRegistrationEndpoint : BaseEndpoint, IEndpoint<GameRegistrationMessage>, IDisposable
    {
        private static string _endPoint = "game_metadata";
        public GameRegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task PostMessageAsync(GameRegistrationMessage message)
        {
            await SerializeAndPostMessageAsync(message);
        }
    }
}
