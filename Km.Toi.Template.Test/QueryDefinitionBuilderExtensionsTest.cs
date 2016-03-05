﻿using Km.Toi.Template.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Km.Toi.Template.Test
{
    public class QueryDefinitionBuilderExtensionsTest
    {
        [Fact]
        public void ToParameterで値をパラメーターに変換できる()
        {
            var builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("123");
            builder.ToParameter("Num", 123);
            var def = builder.Build();
            Assert.Equal("@Num", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo = 1");
            builder.ToParameter("Foo", 123);

            def = builder.Build();
            Assert.Equal("Foo = @Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo=1");
            builder.ToParameter("Foo", 123);

            def = builder.Build();
            Assert.Equal("Foo=@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo>1");
            builder.ToParameter("Foo", 123);

            def = builder.Build();
            Assert.Equal("Foo>@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo<1");
            builder.ToParameter("Foo", 123);

            def = builder.Build();
            Assert.Equal("Foo<@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo=FUNC(1");
            builder.ToParameter("Foo", 123);
            builder.Text.Add(")");
            def = builder.Build();
            Assert.Equal("Foo=FUNC(@Foo)", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("Foo=FUNC(1,2");
            builder.ToParameter("Foo", 123);
            builder.Text.Add(")");
            def = builder.Build();
            Assert.Equal("Foo=FUNC(1,@Foo)", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal(123, def.Parameters[0].Value);

        }

        [Fact]
        public void ToParameterで文字列をパラメーターにできる()
        {
            var builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("'Foo'");
            builder.ToParameter("Foo", "ABC");
            var def = builder.Build();
            Assert.Equal("@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal("ABC", def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("'Fo''o'");
            builder.ToParameter("Foo", "ABC");
            def = builder.Build();
            Assert.Equal("@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal("ABC", def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("'Fo''''o'");
            builder.ToParameter("Foo", "ABC");
            def = builder.Build();
            Assert.Equal("@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal("ABC", def.Parameters[0].Value);

            builder = new QueryDefinitionBuilder(TemplateOptions.Default);
            builder.Text.Add("'F''o''o'");
            builder.ToParameter("Foo", "ABC");
            def = builder.Build();
            Assert.Equal("@Foo", def.QueryText);
            Assert.Equal(1, def.Parameters.Count);
            Assert.Equal("ABC", def.Parameters[0].Value);

        }
    }
}