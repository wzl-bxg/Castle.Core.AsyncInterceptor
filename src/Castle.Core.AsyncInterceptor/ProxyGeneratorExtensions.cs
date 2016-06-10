﻿// Copyright (c) 2016 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Castle.DynamicProxy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extension methods to <see cref="ProxyGenerator"/>,
    /// </summary>
    public static class ProxyGeneratorExtensions
    {
        /// <summary>
        /// Creates an <see cref="IInterceptor"/> for the supplied <paramref name="interceptor"/>.
        /// </summary>
        /// <param name="interceptor">The interceptor for asynchronous operations.</param>
        /// <returns>The <see cref="IInterceptor"/> for the supplied <paramref name="interceptor"/>.</returns>
        public static IInterceptor ToInterceptor(this IAsyncInterceptor interceptor)
        {
            return new AsyncInterceptor(interceptor);
        }

        /// <summary>
        /// Creates an array of <see cref="IInterceptor"/> objects for the supplied <paramref name="interceptors"/>.
        /// </summary>
        /// <param name="interceptors">The interceptors for asynchronous operations.</param>
        /// <returns>The <see cref="IInterceptor"/> array for the supplied <paramref name="interceptors"/>.</returns>
        public static IInterceptor[] ToInterceptors(this IEnumerable<IAsyncInterceptor> interceptors)
        {
            return interceptors.Select(ToInterceptor).ToArray();
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface{TInterface}(TInterface,IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithTarget<TInterface>(
            this ProxyGenerator proxyGenerator,
            TInterface target,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(target, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTarget{TInterface}(TInterface, IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithTarget<TInterface>(
            this ProxyGenerator proxyGenerator,
            TInterface target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(target, options, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTarget(Type, object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(
                interfaceToProxy,
                target,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTarget(Type, object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(
                interfaceToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTarget(Type, Type[], object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(
                interfaceToProxy,
                additionalInterfacesToProxy,
                target,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTarget(Type, Type[], object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTarget(
                interfaceToProxy,
                additionalInterfacesToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface(Type, object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTargetInterface(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(
                interfaceToProxy,
                target,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface{TInterface}(TInterface, IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(
            this ProxyGenerator proxyGenerator,
            TInterface target,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(target, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface{TInterface}(TInterface, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(
            this ProxyGenerator proxyGenerator,
            TInterface target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface(Type, Type[], object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTargetInterface(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(
                interfaceToProxy,
                additionalInterfacesToProxy,
                target,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface(Type, object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTargetInterface(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(
                interfaceToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithTargetInterface(Type, Type[], object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithTargetInterface(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithTargetInterface(
                interfaceToProxy,
                additionalInterfacesToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget{TInterface}(IInterceptor)"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithoutTarget<TInterface>(
            this ProxyGenerator proxyGenerator,
            IAsyncInterceptor interceptor)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget<TInterface>(interceptor.ToInterceptor());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget{TInterface}(IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithoutTarget<TInterface>(
            this ProxyGenerator proxyGenerator,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget<TInterface>(interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget{TInterface}(ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static TInterface CreateInterfaceProxyWithoutTarget<TInterface>(
            this ProxyGenerator proxyGenerator,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
            where TInterface : class
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget<TInterface>(
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type, IInterceptor)"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithoutTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            IAsyncInterceptor interceptor)
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget(interfaceToProxy, interceptor.ToInterceptor());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithoutTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget(interfaceToProxy, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type, Type[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithoutTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget(
                interfaceToProxy,
                additionalInterfacesToProxy,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithoutTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget(
                interfaceToProxy,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateInterfaceProxyWithoutTarget(Type, Type[], ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateInterfaceProxyWithoutTarget(
            this ProxyGenerator proxyGenerator,
            Type interfaceToProxy,
            Type[] additionalInterfacesToProxy,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateInterfaceProxyWithoutTarget(
                interfaceToProxy,
                additionalInterfacesToProxy,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget{TClass}(TClass, IInterceptor[])"/> documentation.
        /// </summary>
        public static TClass CreateClassProxyWithTarget<TClass>(
            this ProxyGenerator proxyGenerator,
            TClass target,
            params IAsyncInterceptor[] interceptors)
            where TClass : class
        {
            return proxyGenerator.CreateClassProxyWithTarget(target, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget{TClass}(TClass, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static TClass CreateClassProxyWithTarget<TClass>(
            this ProxyGenerator proxyGenerator,
            TClass target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
            where TClass : class
        {
            return proxyGenerator.CreateClassProxyWithTarget(target, options, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, Type[], object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                additionalInterfacesToProxy,
                target,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, object, ProxyGenerationOptions, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            object target,
            ProxyGenerationOptions options,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                target,
                options,
                constructorArguments,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, object, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            object target,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                target,
                constructorArguments,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, object, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            object target,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(classToProxy, target, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, Type[], object, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                additionalInterfacesToProxy,
                target,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxyWithTarget(Type, Type[], object, ProxyGenerationOptions, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxyWithTarget(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            object target,
            ProxyGenerationOptions options,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxyWithTarget(
                classToProxy,
                additionalInterfacesToProxy,
                target,
                options,
                constructorArguments,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy{TClass}(IInterceptor[])"/> documentation.
        /// </summary>
        public static TClass CreateClassProxy<TClass>(
            this ProxyGenerator proxyGenerator,
            params IAsyncInterceptor[] interceptors)
            where TClass : class
        {
            return proxyGenerator.CreateClassProxy<TClass>(interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy{TClass}(ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static TClass CreateClassProxy<TClass>(
            this ProxyGenerator proxyGenerator,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
            where TClass : class
        {
            return proxyGenerator.CreateClassProxy<TClass>(options, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, Type[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                additionalInterfacesToProxy,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, ProxyGenerationOptions, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            ProxyGenerationOptions options,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                options,
                constructorArguments,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                constructorArguments,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(classToProxy, interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, Type[], ProxyGenerationOptions, IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            ProxyGenerationOptions options,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                additionalInterfacesToProxy,
                options,
                interceptors.ToInterceptors());
        }

        /// <summary>
        /// See the <see cref="ProxyGenerator.CreateClassProxy(Type, Type[], ProxyGenerationOptions, object[], IInterceptor[])"/> documentation.
        /// </summary>
        public static object CreateClassProxy(
            this ProxyGenerator proxyGenerator,
            Type classToProxy,
            Type[] additionalInterfacesToProxy,
            ProxyGenerationOptions options,
            object[] constructorArguments,
            params IAsyncInterceptor[] interceptors)
        {
            return proxyGenerator.CreateClassProxy(
                classToProxy,
                additionalInterfacesToProxy,
                options,
                constructorArguments,
                interceptors.ToInterceptors());
        }
    }
}
