using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.Handlers.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class when_testing_the_mediator_pattern
    {
        [TestMethod]
        public void then_test_that_all_queries_have_handlers()
        {
            var allTypes =
                    Assembly.GetExecutingAssembly()
                    .GetReferencedAssemblies()
                    .SelectMany(name => Assembly.Load(name).GetTypes())
                    .Union(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()))
                    .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition).ToList();

            var allQueryTypes = (from type in allTypes
                                 let queryInterfaces =
                                     from iface in type.GetInterfaces()
                                     where iface.IsGenericType
                                     where iface.GetGenericTypeDefinition() == typeof(IQuery<>)
                                     select iface
                                 where queryInterfaces.Any()
                                 select type).ToList();

            var allHandlerTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface.IsGenericType
                                       where iface.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();


            // Sanity checks
            Assert.IsTrue(allQueryTypes.Any());
            Assert.IsTrue(allHandlerTypes.Any());
            Assert.IsTrue(allQueryTypes.Count() == allHandlerTypes.Count());

            // Act
            var missingHandlers = new List<string>();
            foreach (var queryType in allQueryTypes)
            {
                var name = queryType.Name.Replace("Query", "");
                var handler = allHandlerTypes.FirstOrDefault(w => w.Name == name + "Handler");
                if (handler == null)
                {
                    missingHandlers.Add(name + "Query does not have a " + name + "Handler");
                }
            }

            // Assert
            var separator = String.Format("{0}", Environment.NewLine);
            var finalMessage = separator + String.Join(separator, missingHandlers);
            Assert.IsTrue(missingHandlers.Count == 0, finalMessage);
        }

        [TestMethod]
        public void then_test_that_all_query_handelrs_have_queries()
        {
            var allTypes =
                    Assembly.GetExecutingAssembly()
                    .GetReferencedAssemblies()
                    .SelectMany(name => Assembly.Load(name).GetTypes())
                    .Union(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()))
                    .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition).ToList();

            var allQueryTypes = (from type in allTypes
                                 let queryInterfaces =
                                     from iface in type.GetInterfaces()
                                     where iface.IsGenericType
                                     where iface.GetGenericTypeDefinition() == typeof(IQuery<>)
                                     select iface
                                 where queryInterfaces.Any()
                                 select type).ToList();

            var allHandlerTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface.IsGenericType
                                       where iface.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();


            // Sanity checks
            Assert.IsTrue(allQueryTypes.Any());
            Assert.IsTrue(allHandlerTypes.Any());
            Assert.IsTrue(allQueryTypes.Count() == allHandlerTypes.Count());

            // Act
            var missingHandlers = new List<string>();
            foreach (var queryType in allHandlerTypes)
            {
                var name = queryType.Name.Replace("Handler", "");
                var handler = allQueryTypes.FirstOrDefault(w => w.Name == name + "Query");
                if (handler == null)
                {
                    missingHandlers.Add(name + "Handler does not have a " + name + "Query");
                }
            }

            // Assert
            var separator = String.Format("{0}", Environment.NewLine);
            var finalMessage = separator + String.Join(separator, missingHandlers);
            Assert.IsTrue(missingHandlers.Count == 0, finalMessage);
        }

        [TestMethod]
        public void then_test_that_all_commands_have_handlers()
        {
            var allTypes =
                    Assembly.GetExecutingAssembly()
                    .GetReferencedAssemblies()
                    .SelectMany(name => Assembly.Load(name).GetTypes())
                    .Union(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()))
                    .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition).ToList();

            var allCommandTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface == typeof(ICommand)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();

            var allHandlerTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface.IsGenericType
                                       where iface.GetGenericTypeDefinition() == typeof(ICommandHandler<>)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();


            // Sanity checks
            Assert.IsTrue(allCommandTypes.Any());
            Assert.IsTrue(allHandlerTypes.Any());

            // Act
            var missingHandlers = new List<string>();
            foreach (var queryType in allCommandTypes)
            {
                var name = queryType.Name.Replace("ViewModel", "");
                var handler = allHandlerTypes.FirstOrDefault(w => w.Name == name + "CommandHandler");
                if (handler == null)
                {
                    missingHandlers.Add(name + "ViewModel does not have a " + name + "CommandHandler");
                }
            }

            // Assert
            var separator = String.Format("{0}", Environment.NewLine);
            var finalMessage = separator + String.Join(separator, missingHandlers);
            Assert.IsTrue(missingHandlers.Count == 0, finalMessage);
        }

        [TestMethod]
        public void then_test_that_all_commands_handlers_have_commands()
        {
            var allTypes =
                    Assembly.GetExecutingAssembly()
                    .GetReferencedAssemblies()
                    .SelectMany(name => Assembly.Load(name).GetTypes())
                    .Union(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()))
                    .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition).ToList();

            var allCommandTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface == typeof(ICommand)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();

            var allHandlerTypes = (from type in allTypes
                                   let queryInterfaces =
                                       from iface in type.GetInterfaces()
                                       where iface.IsGenericType
                                       where iface.GetGenericTypeDefinition() == typeof(ICommandHandler<>)
                                       select iface
                                   where queryInterfaces.Any()
                                   select type).ToList();


            // Sanity checks
            Assert.IsTrue(allCommandTypes.Any());
            Assert.IsTrue(allHandlerTypes.Any());

            // Act
            var missingHandlers = new List<string>();
            foreach (var queryType in allHandlerTypes)
            {
                var name = queryType.Name.Replace("CommandHandler", "");
                var handler = allCommandTypes.FirstOrDefault(w => w.Name == name + "ViewModel");
                if (handler == null)
                {
                    missingHandlers.Add(name + "CommandHandler does not have a " + name + "ViewModel");
                }
            }

            // Assert
            var separator = String.Format("{0}", Environment.NewLine);
            var finalMessage = separator + String.Join(separator, missingHandlers);
            Assert.IsTrue(missingHandlers.Count == 0, finalMessage);
        }

    }
}
