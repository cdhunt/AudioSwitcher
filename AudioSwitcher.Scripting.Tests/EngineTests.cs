﻿using Jurassic;
using Xunit;

namespace AudioSwitcher.Scripting.JavaScript.Tests
{
    public class EngineTests
    {
        [Fact]
        public void Engine_Create()
        {
            var engine = new ScriptEngine();
            Assert.NotNull(engine);
        }

        [Fact]
        public void Engine_WithArgs()
        {

            string[] test = new string[]
            {
                "One",
                "Two"
            };

            var engine = new JsEngine();

            Assert.NotNull(engine.Evaluate<string[]>("args", test));
        }
    }
}
