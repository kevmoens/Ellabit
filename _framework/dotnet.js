//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

var e=!1;const t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,4,1,96,0,0,3,2,1,0,10,8,1,6,0,6,64,25,11,11])),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),n=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),r=Symbol.for("wasm promise_control");function i(e,t){let o=null;const n=new Promise((function(n,r){o={isDone:!1,promise:null,resolve:t=>{o.isDone||(o.isDone=!0,n(t),e&&e())},reject:e=>{o.isDone||(o.isDone=!0,r(e),t&&t())}}}));o.promise=n;const i=n;return i[r]=o,{promise:i,promise_control:o}}function s(e){return e[r]}function a(e){e&&function(e){return void 0!==e[r]}(e)||Be(!1,"Promise is not controllable")}const l="__mono_message__",c=["debug","log","trace","warn","info","error"],d="MONO_WASM: ";let u,f,m,g,p,h;function w(e){g=e}function b(e){if(Pe.diagnosticTracing){const t="function"==typeof e?e():e;console.debug(d+t)}}function y(e,...t){console.info(d+e,...t)}function v(e,...t){console.info(e,...t)}function E(e,...t){console.warn(d+e,...t)}function _(e,...t){if(t&&t.length>0&&t[0]&&"object"==typeof t[0]){if(t[0].silent)return;if(t[0].toString)return void console.error(d+e,t[0].toString())}console.error(d+e,...t)}function x(e,t,o){return function(...n){try{let r=n[0];if(void 0===r)r="undefined";else if(null===r)r="null";else if("function"==typeof r)r=r.toString();else if("string"!=typeof r)try{r=JSON.stringify(r)}catch(e){r=r.toString()}t(o?JSON.stringify({method:e,payload:r,arguments:n.slice(1)}):[e+r,...n.slice(1)])}catch(e){m.error(`proxyConsole failed: ${e}`)}}}function j(e,t,o){f=t,g=e,m={...t};const n=`${o}/console`.replace("https://","wss://").replace("http://","ws://");u=new WebSocket(n),u.addEventListener("error",A),u.addEventListener("close",S),function(){for(const e of c)f[e]=x(`console.${e}`,T,!0)}()}function R(e){let t=30;const o=()=>{u?0==u.bufferedAmount||0==t?(e&&v(e),function(){for(const e of c)f[e]=x(`console.${e}`,m.log,!1)}(),u.removeEventListener("error",A),u.removeEventListener("close",S),u.close(1e3,e),u=void 0):(t--,globalThis.setTimeout(o,100)):e&&m&&m.log(e)};o()}function T(e){u&&u.readyState===WebSocket.OPEN?u.send(e):m.log(e)}function A(e){m.error(`[${g}] proxy console websocket error: ${e}`,e)}function S(e){m.debug(`[${g}] proxy console websocket closed: ${e}`,e)}function D(){Pe.preferredIcuAsset=O(Pe.config);let e="invariant"==Pe.config.globalizationMode;if(!e)if(Pe.preferredIcuAsset)Pe.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===Pe.config.globalizationMode||"all"===Pe.config.globalizationMode||"sharded"===Pe.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}Pe.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,Pe.preferredIcuAsset=null}const t="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",o=Pe.config.environmentVariables;if(void 0===o[t]&&e&&(o[t]="1"),void 0===o.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(o.TZ=e)}catch(e){y("failed to detect timezone, will fallback to UTC")}}function O(e){var t;if((null===(t=e.resources)||void 0===t?void 0:t.icu)&&"invariant"!=e.globalizationMode){const t=e.applicationCulture||(ke?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale),o=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(o.length>=1)return o[0].name}else t&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const t=e.split("-")[0];return"en"===t||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(t)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(t)):n="icudt.dat";if(n)for(let e=0;e<o.length;e++){const t=o[e];if(t.virtualPath===n)return t.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const C=class{constructor(e){this.url=e}toString(){return this.url}};async function k(e,t){try{const o="function"==typeof globalThis.fetch;if(Se){const n=e.startsWith("file://");if(!n&&o)return globalThis.fetch(e,t||{credentials:"same-origin"});p||(h=Ne.require("url"),p=Ne.require("fs")),n&&(e=h.fileURLToPath(e));const r=await p.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>r,json:()=>JSON.parse(r),text:()=>{throw new Error("NotImplementedException")}}}if(o)return globalThis.fetch(e,t||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(t){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t},text:()=>{throw t}}}throw new Error("No fetch implementation available")}function I(e){return"string"!=typeof e&&Be(!1,"url must be a string"),!M(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}const U=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,P=/[a-zA-Z]:[\\/]/;function M(e){return Se||Ie?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||P.test(e):U.test(e)}let L,N=0;const $=[],z=[],W=new Map,F={"js-module-threads":!0,"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},B={...F,"js-module-library-initializer":!0},V={...F,dotnetwasm:!0,heap:!0,manifest:!0},q={...B,manifest:!0},H={...B,dotnetwasm:!0},J={dotnetwasm:!0,symbols:!0},Z={...B,dotnetwasm:!0,symbols:!0},Q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=Pe.preferredIcuAsset)}function K(e,t,o){null!=t||(t=[]),Be(1==t.length,`Expect to have one ${o} asset in resources`);const n=t[0];return n.behavior=o,X(n),e.push(n),n}function X(e){V[e.behavior]&&W.set(e.behavior,e)}function Y(e){Be(V[e],`Unknown single asset behavior ${e}`);const t=W.get(e);if(t&&!t.resolvedUrl)if(t.resolvedUrl=Pe.locateFile(t.name),F[t.behavior]){const e=ge(t);e?("string"!=typeof e&&Be(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),t.resolvedUrl=e):t.resolvedUrl=ce(t.resolvedUrl,t.behavior)}else if("dotnetwasm"!==t.behavior)throw new Error(`Unknown single asset behavior ${e}`);return t}function ee(e){const t=Y(e);return Be(t,`Single asset for ${e} not found`),t}let te=!1;async function oe(){if(!te){te=!0,Pe.diagnosticTracing&&b("mono_download_assets");try{const e=[],t=[],o=(e,t)=>{!Z[e.behavior]&&G(e)&&Pe.expected_instantiated_assets_count++,!H[e.behavior]&&G(e)&&(Pe.expected_downloaded_assets_count++,t.push(se(e)))};for(const t of $)o(t,e);for(const e of z)o(e,t);Pe.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...t]).then((()=>{Pe.allDownloadsFinished.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),await Pe.runtimeModuleLoaded.promise;const n=async e=>{const t=await e;if(t.buffer){if(!Z[t.behavior]){t.buffer&&"object"==typeof t.buffer||Be(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof t.resolvedUrl&&Be(!1,"resolvedUrl must be string");const e=t.resolvedUrl,o=await t.buffer,n=new Uint8Array(o);pe(t),await Ue.beforeOnRuntimeInitialized.promise,Ue.instantiate_asset(t,e,n)}}else J[t.behavior]?("symbols"===t.behavior&&(await Ue.instantiate_symbols_asset(t),pe(t)),J[t.behavior]&&++Pe.actual_downloaded_assets_count):(t.isOptional||Be(!1,"Expected asset to have the downloaded buffer"),!H[t.behavior]&&G(t)&&Pe.expected_downloaded_assets_count--,!Z[t.behavior]&&G(t)&&Pe.expected_instantiated_assets_count--)},r=[],i=[];for(const t of e)r.push(n(t));for(const e of t)i.push(n(e));Promise.all(r).then((()=>{Ce||Ue.coreAssetsInMemory.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),Promise.all(i).then((async()=>{Ce||(await Ue.coreAssetsInMemory.promise,Ue.allAssetsInMemory.promise_control.resolve())})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e}))}catch(e){throw Pe.err("Error in mono_download_assets: "+e),e}}}let ne=!1;function re(){if(ne)return;ne=!0;const e=Pe.config,t=[];if(e.assets)for(const t of e.assets)"object"!=typeof t&&Be(!1,`asset must be object, it was ${typeof t} : ${t}`),"string"!=typeof t.behavior&&Be(!1,"asset behavior must be known string"),"string"!=typeof t.name&&Be(!1,"asset name must be string"),t.resolvedUrl&&"string"!=typeof t.resolvedUrl&&Be(!1,"asset resolvedUrl could be string"),t.hash&&"string"!=typeof t.hash&&Be(!1,"asset resolvedUrl could be string"),t.pendingDownload&&"object"!=typeof t.pendingDownload&&Be(!1,"asset pendingDownload could be object"),t.isCore?$.push(t):z.push(t),X(t);else if(e.resources){const o=e.resources;o.wasmNative||Be(!1,"resources.wasmNative must be defined"),o.jsModuleNative||Be(!1,"resources.jsModuleNative must be defined"),o.jsModuleRuntime||Be(!1,"resources.jsModuleRuntime must be defined"),K(z,o.wasmNative,"dotnetwasm"),K(t,o.jsModuleNative,"js-module-native"),K(t,o.jsModuleRuntime,"js-module-runtime"),o.jsModuleDiagnostics&&K(t,o.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,t,o)=>{const n=e;n.behavior=t,o?(n.isCore=!0,$.push(n)):z.push(n)};if(o.coreAssembly)for(let e=0;e<o.coreAssembly.length;e++)n(o.coreAssembly[e],"assembly",!0);if(o.assembly)for(let e=0;e<o.assembly.length;e++)n(o.assembly[e],"assembly",!o.coreAssembly);if(0!=e.debugLevel&&Pe.isDebuggingSupported()){if(o.corePdb)for(let e=0;e<o.corePdb.length;e++)n(o.corePdb[e],"pdb",!0);if(o.pdb)for(let e=0;e<o.pdb.length;e++)n(o.pdb[e],"pdb",!o.corePdb)}if(e.loadAllSatelliteResources&&o.satelliteResources)for(const e in o.satelliteResources)for(let t=0;t<o.satelliteResources[e].length;t++){const r=o.satelliteResources[e][t];r.culture=e,n(r,"resource",!o.coreAssembly)}if(o.coreVfs)for(let e=0;e<o.coreVfs.length;e++)n(o.coreVfs[e],"vfs",!0);if(o.vfs)for(let e=0;e<o.vfs.length;e++)n(o.vfs[e],"vfs",!o.coreVfs);const r=O(e);if(r&&o.icu)for(let e=0;e<o.icu.length;e++){const t=o.icu[e];t.name===r&&n(t,"icu",!1)}if(o.wasmSymbols)for(let e=0;e<o.wasmSymbols.length;e++)n(o.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let t=0;t<e.appsettings.length;t++){const o=e.appsettings[t],n=he(o);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||z.push({name:o,behavior:"vfs",noCache:!0,useCredentials:!0})}e.assets=[...$,...z,...t]}async function ie(e){const t=await se(e);return await t.pendingDownloadInternal.response,t.buffer}async function se(e){try{return await ae(e)}catch(t){if(!Pe.enableDownloadRetry)throw t;if(Ie||Se)throw t;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw t;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw t;if(t&&404==t.status)throw t;e.pendingDownloadInternal=void 0,await Pe.allDownloadsQueued.promise;try{return Pe.diagnosticTracing&&b(`Retrying download '${e.name}'`),await ae(e)}catch(t){return e.pendingDownloadInternal=void 0,await new Promise((e=>globalThis.setTimeout(e,100))),Pe.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await ae(e)}}}async function ae(e){for(;L;)await L.promise;try{++N,N==Pe.maxParallelDownloads&&(Pe.diagnosticTracing&&b("Throttling further parallel downloads"),L=i());const t=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const t=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>t,json:()=>JSON.parse(new TextDecoder("utf-8").decode(t)),text:()=>{throw new Error("NotImplementedException")},headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const t=e.loadRemote&&Pe.config.remoteSources?Pe.config.remoteSources:[""];let o;for(let n of t){n=n.trim(),"./"===n&&(n="");const t=le(e,n);e.name===t?Pe.diagnosticTracing&&b(`Attempting to download '${t}'`):Pe.diagnosticTracing&&b(`Attempting to download '${t}' for ${e.name}`);try{e.resolvedUrl=t;const n=fe(e);if(e.pendingDownloadInternal=n,o=await n.response,!o||!o.ok)continue;return o}catch(e){o||(o={ok:!1,url:t,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&Pe.config.ignorePdbLoadErrors;if(o||Be(!1,`Response undefined ${e.name}`),!n){const t=new Error(`download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`);throw t.status=o.status,t}y(`optional download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`)}(e);return t?(J[e.behavior]||(e.buffer=await t.arrayBuffer(),++Pe.actual_downloaded_assets_count),e):e}finally{if(--N,L&&N==Pe.maxParallelDownloads-1){Pe.diagnosticTracing&&b("Resuming more parallel downloads");const e=L;L=void 0,e.promise_control.resolve()}}}function le(e,t){let o;return null==t&&Be(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?o=e.resolvedUrl:(o=""===t?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:t+e.name,o=ce(Pe.locateFile(o),e.behavior)),o&&"string"==typeof o||Be(!1,"attemptUrl need to be path or url string"),o}function ce(e,t){return Pe.modulesUniqueQuery&&q[t]&&(e+=Pe.modulesUniqueQuery),e}let de=0;const ue=new Set;function fe(e){try{e.resolvedUrl||Be(!1,"Request's resolvedUrl must be set");const t=function(e){let t=e.resolvedUrl;if(Pe.loadBootResource){const o=ge(e);if(o instanceof Promise)return o;"string"==typeof o&&(t=o)}const o={};return Pe.config.disableNoCacheFetch||(o.cache="no-cache"),e.useCredentials?o.credentials="include":!Pe.config.disableIntegrityCheck&&e.hash&&(o.integrity=e.hash),Pe.fetch_like(t,o)}(e),o={name:e.name,url:e.resolvedUrl,response:t};return ue.add(e.name),o.response.then((()=>{"assembly"==e.behavior&&Pe.loadedAssemblies.push(e.name),de++,Pe.onDownloadResourceProgress&&Pe.onDownloadResourceProgress(de,ue.size)})),o}catch(t){const o={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(o)}}}const me={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs","js-module-threads":"dotnetjs"};function ge(e){var t;if(Pe.loadBootResource){const o=null!==(t=e.hash)&&void 0!==t?t:"",n=e.resolvedUrl,r=me[e.behavior];if(r){const t=Pe.loadBootResource(r,e.name,n,o,e.behavior);return"string"==typeof t?I(t):t}}}function pe(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function he(e){let t=e.lastIndexOf("/");return t>=0&&t++,e.substring(t)}async function we(e){e&&await Promise.all((null!=e?e:[]).map((e=>async function(e){try{const t=e.name;if(!e.moduleExports){const o=ce(Pe.locateFile(t),"js-module-library-initializer");Pe.diagnosticTracing&&b(`Attempting to import '${o}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */o)}Pe.libraryInitializers.push({scriptName:t,exports:e.moduleExports})}catch(t){E(`Failed to import library initializer '${e}': ${t}`)}}(e))))}async function be(e,t){if(!Pe.libraryInitializers)return;const o=[];for(let n=0;n<Pe.libraryInitializers.length;n++){const r=Pe.libraryInitializers[n];r.exports[e]&&o.push(ye(r.scriptName,e,(()=>r.exports[e](...t))))}await Promise.all(o)}async function ye(e,t,o){try{await o()}catch(o){throw E(`Failed to invoke '${t}' on library initializer '${e}': ${o}`),Xe(1,o),o}}function ve(e,t){if(e===t)return e;const o={...t};return void 0!==o.assets&&o.assets!==e.assets&&(o.assets=[...e.assets||[],...o.assets||[]]),void 0!==o.resources&&(o.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},o.resources)),void 0!==o.environmentVariables&&(o.environmentVariables={...e.environmentVariables||{},...o.environmentVariables||{}}),void 0!==o.runtimeOptions&&o.runtimeOptions!==e.runtimeOptions&&(o.runtimeOptions=[...e.runtimeOptions||[],...o.runtimeOptions||[]]),Object.assign(e,o)}function Ee(e,t){if(e===t)return e;const o={...t};return o.config&&(e.config||(e.config={}),o.config=ve(e.config,o.config)),Object.assign(e,o)}function _e(e,t){if(e===t)return e;const o={...t};return void 0!==o.coreAssembly&&(o.coreAssembly=[...e.coreAssembly||[],...o.coreAssembly||[]]),void 0!==o.assembly&&(o.assembly=[...e.assembly||[],...o.assembly||[]]),void 0!==o.lazyAssembly&&(o.lazyAssembly=[...e.lazyAssembly||[],...o.lazyAssembly||[]]),void 0!==o.corePdb&&(o.corePdb=[...e.corePdb||[],...o.corePdb||[]]),void 0!==o.pdb&&(o.pdb=[...e.pdb||[],...o.pdb||[]]),void 0!==o.jsModuleWorker&&(o.jsModuleWorker=[...e.jsModuleWorker||[],...o.jsModuleWorker||[]]),void 0!==o.jsModuleNative&&(o.jsModuleNative=[...e.jsModuleNative||[],...o.jsModuleNative||[]]),void 0!==o.jsModuleDiagnostics&&(o.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...o.jsModuleDiagnostics||[]]),void 0!==o.jsModuleRuntime&&(o.jsModuleRuntime=[...e.jsModuleRuntime||[],...o.jsModuleRuntime||[]]),void 0!==o.wasmSymbols&&(o.wasmSymbols=[...e.wasmSymbols||[],...o.wasmSymbols||[]]),void 0!==o.wasmNative&&(o.wasmNative=[...e.wasmNative||[],...o.wasmNative||[]]),void 0!==o.icu&&(o.icu=[...e.icu||[],...o.icu||[]]),void 0!==o.satelliteResources&&(o.satelliteResources=function(e,t){if(e===t)return e;for(const o in t)e[o]=[...e[o]||[],...t[o]||[]];return e}(e.satelliteResources||{},o.satelliteResources||{})),void 0!==o.modulesAfterConfigLoaded&&(o.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...o.modulesAfterConfigLoaded||[]]),void 0!==o.modulesAfterRuntimeReady&&(o.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...o.modulesAfterRuntimeReady||[]]),void 0!==o.extensions&&(o.extensions={...e.extensions||{},...o.extensions||{}}),void 0!==o.vfs&&(o.vfs=[...e.vfs||[],...o.vfs||[]]),Object.assign(e,o)}function xe(){const e=Pe.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleWorker:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){Pe.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const t of e.assets){const o={};switch(t.behavior){case"assembly":o.assembly=[t];break;case"pdb":o.pdb=[t];break;case"resource":o.satelliteResources={},o.satelliteResources[t.culture]=[t];break;case"icu":o.icu=[t];break;case"symbols":o.wasmSymbols=[t];break;case"vfs":o.vfs=[t];break;case"dotnetwasm":o.wasmNative=[t];break;case"js-module-threads":o.jsModuleWorker=[t];break;case"js-module-runtime":o.jsModuleRuntime=[t];break;case"js-module-native":o.jsModuleNative=[t];break;case"js-module-diagnostics":o.jsModuleDiagnostics=[t];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${t.behavior} of asset ${t.name}`)}_e(e.resources,o)}}e.debugLevel,e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Ue.diagnosticTracing=Pe.diagnosticTracing=!!e.diagnosticTracing,Ue.waitForDebugger=e.waitForDebugger,Pe.maxParallelDownloads=e.maxParallelDownloads||Pe.maxParallelDownloads,Pe.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:Pe.enableDownloadRetry}let je=!1;async function Re(e){var t;if(je)return void await Pe.afterConfigLoaded.promise;let o;try{if(e.configSrc||Pe.config&&0!==Object.keys(Pe.config).length&&(Pe.config.assets||Pe.config.resources)||(e.configSrc="dotnet.boot.js"),o=e.configSrc,je=!0,o&&(Pe.diagnosticTracing&&b("mono_wasm_load_config"),await async function(e){const t=e.configSrc,o=Pe.locateFile(t);let n=null;void 0!==Pe.loadBootResource&&(n=Pe.loadBootResource("manifest",t,o,"","manifest"));let r,i=null;if(n)if("string"==typeof n)n.includes(".json")?(i=await s(I(n)),r=await Ae(i)):r=(await import(I(n))).config;else{const e=await n;"function"==typeof e.json?(i=e,r=await Ae(i)):r=e.config}else o.includes(".json")?(i=await s(ce(o,"manifest")),r=await Ae(i)):r=(await import(ce(o,"manifest"))).config;function s(e){return Pe.fetch_like(e,{method:"GET",credentials:"include",cache:"no-cache"})}Pe.config.applicationEnvironment&&(r.applicationEnvironment=Pe.config.applicationEnvironment),ve(Pe.config,r)}(e)),xe(),await we(null===(t=Pe.config.resources)||void 0===t?void 0:t.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[Pe.config]),e.onConfigLoaded)try{await e.onConfigLoaded(Pe.config,Le),xe()}catch(e){throw _("onConfigLoaded() failed",e),e}xe(),Pe.afterConfigLoaded.promise_control.resolve(Pe.config)}catch(t){const n=`Failed to load config file ${o} ${t} ${null==t?void 0:t.stack}`;throw Pe.config=e.config=Object.assign(Pe.config,{message:n,error:t,isError:!0}),Xe(1,new Error(n)),t}}function Te(){return!!globalThis.navigator&&(Pe.isChromium||Pe.isFirefox)}async function Ae(e){const t=Pe.config,o=await e.json();t.applicationEnvironment||o.applicationEnvironment||(o.applicationEnvironment=e.headers.get("Blazor-Environment")||e.headers.get("DotNet-Environment")||void 0),o.environmentVariables||(o.environmentVariables={});const n=e.headers.get("DOTNET-MODIFIABLE-ASSEMBLIES");n&&(o.environmentVariables.DOTNET_MODIFIABLE_ASSEMBLIES=n);const r=e.headers.get("ASPNETCORE-BROWSER-TOOLS");return r&&(o.environmentVariables.__ASPNETCORE_BROWSER_TOOLS=r),o}"function"!=typeof importScripts||globalThis.onmessage||(globalThis.dotnetSidecar=!0);const Se="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,De="function"==typeof importScripts,Oe=De&&"undefined"!=typeof dotnetSidecar,Ce=De&&!Oe,ke="object"==typeof window||De&&!Se,Ie=!ke&&!Se;let Ue={},Pe={},Me={},Le={},Ne={},$e=!1;const ze={},We={config:ze},Fe={mono:{},binding:{},internal:Ne,module:We,loaderHelpers:Pe,runtimeHelpers:Ue,diagnosticHelpers:Me,api:Le};function Be(e,t){if(e)return;const o="Assert failed: "+("function"==typeof t?t():t),n=new Error(o);_(o,n),Ue.nativeAbort(n)}function Ve(){return void 0!==Pe.exitCode}function qe(){return Ue.runtimeReady&&!Ve()}function He(){Ve()&&Be(!1,`.NET runtime already exited with ${Pe.exitCode} ${Pe.exitReason}. You can use runtime.runMain() which doesn't exit the runtime.`),Ue.runtimeReady||Be(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function Je(){ke&&(globalThis.addEventListener("unhandledrejection",et),globalThis.addEventListener("error",tt))}let Ze,Qe;function Ge(e){Qe&&Qe(e),Xe(e,Pe.exitReason)}function Ke(e){Ze&&Ze(e||Pe.exitReason),Xe(1,e||Pe.exitReason)}function Xe(t,o){var n,r;const i=o&&"object"==typeof o;t=i&&"number"==typeof o.status?o.status:void 0===t?-1:t;const s=i&&"string"==typeof o.message?o.message:""+o;(o=i?o:Ue.ExitStatus?function(e,t){const o=new Ue.ExitStatus(e);return o.message=t,o.toString=()=>t,o}(t,s):new Error("Exit with code "+t+" "+s)).status=t,o.message||(o.message=s);const a=""+(o.stack||(new Error).stack);try{Object.defineProperty(o,"stack",{get:()=>a})}catch(e){}const l=!!o.silent;if(o.silent=!0,Ve())Pe.diagnosticTracing&&b("mono_exit called after exit");else{try{We.onAbort==Ke&&(We.onAbort=Ze),We.onExit==Ge&&(We.onExit=Qe),ke&&(globalThis.removeEventListener("unhandledrejection",et),globalThis.removeEventListener("error",tt)),Ue.runtimeReady?(Ue.jiterpreter_dump_stats&&Ue.jiterpreter_dump_stats(!1),0===t&&(null===(n=Pe.config)||void 0===n?void 0:n.interopCleanupOnExit)&&Ue.forceDisposeProxies(!0,!0),e&&0!==t&&(null===(r=Pe.config)||void 0===r||r.dumpThreadsOnNonZeroExit)):(Pe.diagnosticTracing&&b(`abort_startup, reason: ${o}`),function(e){Pe.allDownloadsQueued.promise_control.reject(e),Pe.allDownloadsFinished.promise_control.reject(e),Pe.afterConfigLoaded.promise_control.reject(e),Pe.wasmCompilePromise.promise_control.reject(e),Pe.runtimeModuleLoaded.promise_control.reject(e),Ue.dotnetReady&&(Ue.dotnetReady.promise_control.reject(e),Ue.afterInstantiateWasm.promise_control.reject(e),Ue.beforePreInit.promise_control.reject(e),Ue.afterPreInit.promise_control.reject(e),Ue.afterPreRun.promise_control.reject(e),Ue.beforeOnRuntimeInitialized.promise_control.reject(e),Ue.afterOnRuntimeInitialized.promise_control.reject(e),Ue.afterPostRun.promise_control.reject(e))}(o))}catch(e){E("mono_exit A failed",e)}try{l||(function(e,t){if(0!==e&&t){const e=Ue.ExitStatus&&t instanceof Ue.ExitStatus?b:_;"string"==typeof t?e(t):(void 0===t.stack&&(t.stack=(new Error).stack+""),t.message?e(Ue.stringify_as_error_with_stack?Ue.stringify_as_error_with_stack(t.message+"\n"+t.stack):t.message+"\n"+t.stack):e(JSON.stringify(t)))}!Ce&&Pe.config&&(Pe.config.logExitCode?Pe.config.forwardConsoleLogsToWS?R("WASM EXIT "+e):v("WASM EXIT "+e):Pe.config.forwardConsoleLogsToWS&&R())}(t,o),function(e){if(ke&&!Ce&&Pe.config&&Pe.config.appendElementOnExit&&document){const t=document.createElement("label");t.id="tests_done",0!==e&&(t.style.background="red"),t.innerHTML=""+e,document.body.appendChild(t)}}(t))}catch(e){E("mono_exit B failed",e)}Pe.exitCode=t,Pe.exitReason||(Pe.exitReason=o),!Ce&&Ue.runtimeReady&&We.runtimeKeepalivePop()}if(Pe.config&&Pe.config.asyncFlushOnExit&&0===t)throw(async()=>{try{await async function(){try{const e=await import(/*! webpackIgnore: true */"process"),t=e=>new Promise(((t,o)=>{e.on("error",o),e.end("","utf8",t)})),o=t(e.stderr),n=t(e.stdout);let r;const i=new Promise((e=>{r=setTimeout((()=>e("timeout")),1e3)}));await Promise.race([Promise.all([n,o]),i]),clearTimeout(r)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Ye(t,o)}})(),o;Ye(t,o)}function Ye(e,t){if(Ue.runtimeReady&&Ue.nativeExit)try{Ue.nativeExit(e)}catch(e){!Ue.ExitStatus||e instanceof Ue.ExitStatus||E("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!ke)throw Se&&Ne.process?Ne.process.exit(e):Ue.quit&&Ue.quit(e,t),t}function et(e){ot(e,e.reason,"rejection")}function tt(e){ot(e,e.error,"error")}function ot(e,t,o){e.preventDefault();try{t||(t=new Error("Unhandled "+o)),void 0===t.stack&&(t.stack=(new Error).stack),t.stack=t.stack+"",t.silent||(_("Unhandled error:",t),Xe(1,t))}catch(e){}}!function(e){if($e)throw new Error("Loader module already loaded");$e=!0,Ue=e.runtimeHelpers,Pe=e.loaderHelpers,Me=e.diagnosticHelpers,Le=e.api,Ne=e.internal,Object.assign(Le,{INTERNAL:Ne,invokeLibraryInitializers:be}),Object.assign(e.module,{config:ve(ze,{environmentVariables:{}})});const r={mono_wasm_bindings_is_ready:!1,config:e.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"fad253f51b461736dfd3cd9c15977bb7493becef",config:e.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:i(),allDownloadsQueued:i(),allDownloadsFinished:i(),wasmCompilePromise:i(),runtimeModuleLoaded:i(),loadingWorkers:i(),is_exited:Ve,is_runtime_running:qe,assert_runtime_running:He,mono_exit:Xe,createPromiseController:i,getPromiseController:s,assertIsControllablePromise:a,mono_download_assets:oe,resolve_single_asset_path:ee,setup_proxy_console:j,set_thread_prefix:w,installUnhandledErrorHandler:Je,retrieve_asset_download:ie,invokeLibraryInitializers:be,isDebuggingSupported:Te,exceptions:t,simd:n,relaxedSimd:o};Object.assign(Ue,r),Object.assign(Pe,l)}(Fe);let nt,rt,it,st=!1,at=!1;async function lt(e){if(!at){if(at=!0,ke&&Pe.config.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&j("main",globalThis.console,globalThis.location.origin),We||Be(!1,"Null moduleConfig"),Pe.config||Be(!1,"Null moduleConfig.config"),"function"==typeof e){const t=e(Fe.api);if(t.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(We,t),Ee(We,t)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");Ee(We,e)}await async function(e){if(Se){const e=await import(/*! webpackIgnore: true */"process"),t=14;if(e.versions.node.split(".")[0]<t)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${t}. See also https://aka.ms/dotnet-wasm-features`)}const t=/*! webpackIgnore: true */import.meta.url,o=t.indexOf("?");var n;if(o>0&&(Pe.modulesUniqueQuery=t.substring(o)),Pe.scriptUrl=t.replace(/\\/g,"/").replace(/[?#].*/,""),Pe.scriptDirectory=(n=Pe.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",Pe.locateFile=e=>"URL"in globalThis&&globalThis.URL!==C?new URL(e,Pe.scriptDirectory).toString():M(e)?e:Pe.scriptDirectory+e,Pe.fetch_like=k,Pe.out=console.log,Pe.err=console.error,Pe.onDownloadResourceProgress=e.onDownloadResourceProgress,ke&&globalThis.navigator){const e=globalThis.navigator,t=e.userAgentData&&e.userAgentData.brands;t&&t.length>0?Pe.isChromium=t.some((e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand)):e.userAgent&&(Pe.isChromium=e.userAgent.includes("Chrome"),Pe.isFirefox=e.userAgent.includes("Firefox"))}Ne.require=Se?await import(/*! webpackIgnore: true */"module").then((e=>e.createRequire(/*! webpackIgnore: true */import.meta.url))):Promise.resolve((()=>{throw new Error("require not supported")})),void 0===globalThis.URL&&(globalThis.URL=C)}(We)}}async function ct(e){return await lt(e),Ze=We.onAbort,Qe=We.onExit,We.onAbort=Ke,We.onExit=Ge,We.ENVIRONMENT_IS_PTHREAD?async function(){(function(){const e=new MessageChannel,t=e.port1,o=e.port2;t.addEventListener("message",(e=>{var n,r;n=JSON.parse(e.data.config),r=JSON.parse(e.data.monoThreadInfo),st?Pe.diagnosticTracing&&b("mono config already received"):(ve(Pe.config,n),Ue.monoThreadInfo=r,xe(),Pe.diagnosticTracing&&b("mono config received"),st=!0,Pe.afterConfigLoaded.promise_control.resolve(Pe.config),ke&&n.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&Pe.setup_proxy_console("worker-idle",console,globalThis.location.origin)),t.close(),o.close()}),{once:!0}),t.start(),self.postMessage({[l]:{monoCmd:"preload",port:o}},[o])})(),await Pe.afterConfigLoaded.promise,function(){const e=Pe.config;e.assets||Be(!1,"config.assets must be defined");for(const t of e.assets)X(t),Q[t.behavior]&&z.push(t)}(),setTimeout((async()=>{try{await oe()}catch(e){Xe(1,e)}}),0);const e=dt(),t=await Promise.all(e);return await ut(t),We}():async function(){var e;await Re(We),re();const t=dt();(async function(){try{const e=ee("dotnetwasm");await se(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||Be(!1,"Can't load dotnet.native.wasm");const t=await e.pendingDownloadInternal.response,o=t.headers&&t.headers.get?t.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===o)n=await WebAssembly.compileStreaming(t);else{ke&&"application/wasm"!==o&&E('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await t.arrayBuffer();Pe.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Ie?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,Pe.wasmCompilePromise.promise_control.resolve(n)}catch(e){Pe.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout((async()=>{try{D(),await oe()}catch(e){Xe(1,e)}}),0);const o=await Promise.all(t);return await ut(o),await Ue.dotnetReady.promise,await we(null===(e=Pe.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[Fe.api]),Le}()}function dt(){const e=ee("js-module-runtime"),t=ee("js-module-native");if(nt&&rt)return[nt,rt,it];"object"==typeof e.moduleExports?nt=e.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),nt=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof t.moduleExports?rt=t.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),rt=import(/*! webpackIgnore: true */t.resolvedUrl));const o=Y("js-module-diagnostics");return o&&("object"==typeof o.moduleExports?it=o.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),it=import(/*! webpackIgnore: true */o.resolvedUrl))),[nt,rt,it]}async function ut(e){const{initializeExports:t,initializeReplacements:o,configureRuntimeStartup:n,configureEmscriptenStartup:r,configureWorkerStartup:i,setRuntimeGlobals:s,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];s(Fe),t(Fe),c&&c.setRuntimeGlobals(Fe),await n(We),Pe.runtimeModuleLoaded.promise_control.resolve(),l((e=>(Object.assign(We,{ready:e.ready,__dotnet_runtime:{initializeReplacements:o,configureEmscriptenStartup:r,configureWorkerStartup:i,passEmscriptenInternals:a}}),We))).catch((e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize. See also https://aka.ms/dotnet-wasm-features");throw e}))}const ft=new class{withModuleConfig(e){try{return Ee(We,e),this}catch(e){throw Xe(1,e),e}}withOnConfigLoaded(e){try{return Ee(We,{onConfigLoaded:e}),this}catch(e){throw Xe(1,e),e}}withConsoleForwarding(){try{return ve(ze,{forwardConsoleLogsToWS:!0}),this}catch(e){throw Xe(1,e),e}}withExitOnUnhandledError(){try{return ve(ze,{exitOnUnhandledError:!0}),Je(),this}catch(e){throw Xe(1,e),e}}withAsyncFlushOnExit(){try{return ve(ze,{asyncFlushOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withExitCodeLogging(){try{return ve(ze,{logExitCode:!0}),this}catch(e){throw Xe(1,e),e}}withElementOnExit(){try{return ve(ze,{appendElementOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withInteropCleanupOnExit(){try{return ve(ze,{interopCleanupOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withDumpThreadsOnNonZeroExit(){try{return ve(ze,{dumpThreadsOnNonZeroExit:!0}),this}catch(e){throw Xe(1,e),e}}withWaitingForDebugger(e){try{return ve(ze,{waitForDebugger:e}),this}catch(e){throw Xe(1,e),e}}withInterpreterPgo(e,t){try{return ve(ze,{interpreterPgo:e,interpreterPgoSaveDelay:t}),ze.runtimeOptions?ze.runtimeOptions.push("--interp-pgo-recording"):ze.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Xe(1,e),e}}withConfig(e){try{return ve(ze,e),this}catch(e){throw Xe(1,e),e}}withConfigSrc(e){try{return e&&"string"==typeof e||Be(!1,"must be file path or URL"),Ee(We,{configSrc:e}),this}catch(e){throw Xe(1,e),e}}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||Be(!1,"must be directory path"),ve(ze,{virtualWorkingDirectory:e}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariable(e,t){try{const o={};return o[e]=t,ve(ze,{environmentVariables:o}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||Be(!1,"must be dictionary object"),ve(ze,{environmentVariables:e}),this}catch(e){throw Xe(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&Be(!1,"must be boolean"),ve(ze,{diagnosticTracing:e}),this}catch(e){throw Xe(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||Be(!1,"must be number"),ve(ze,{debugLevel:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ve(ze,{applicationArguments:e}),this}catch(e){throw Xe(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ze.runtimeOptions?ze.runtimeOptions.push(...e):ze.runtimeOptions=e,this}catch(e){throw Xe(1,e),e}}withMainAssembly(e){try{return ve(ze,{mainAssemblyName:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Xe(1,e),e}}withApplicationEnvironment(e){try{return ve(ze,{applicationEnvironment:e}),this}catch(e){throw Xe(1,e),e}}withApplicationCulture(e){try{return ve(ze,{applicationCulture:e}),this}catch(e){throw Xe(1,e),e}}withResourceLoader(e){try{return Pe.loadBootResource=e,this}catch(e){throw Xe(1,e),e}}async download(){try{await async function(){lt(We),await Re(We),re(),D(),oe(),await Pe.allDownloadsFinished.promise}()}catch(e){throw Xe(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await ct(We),Fe.api}()),this.instance}catch(e){throw Xe(1,e),e}}async run(){try{return We.config||Be(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Xe(1,e),e}}},mt=Xe,gt=ct;Ie||"function"==typeof globalThis.URL||Be(!1,"This browser/engine doesn't support URL API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),"function"!=typeof globalThis.BigInt64Array&&Be(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),ft.withConfig(/*json-start*/{
  "mainAssemblyName": "Ellabit",
  "resources": {
    "hash": "sha256-4JsmUrb9OMarmAagEXDvC+E2Cl1C1arb7tUwXyYVCYQ=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.cs8mcre4gh.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.0j6ezsi0n0.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.muve7a13r4.wasm",
        "integrity": "sha256-vjddPOzSD1RO9Een4QrlAPnxzBSmD/QchBKKmBMLZwg="
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt_CJK.dat",
        "name": "icudt_CJK.tjcz0u77k5.dat",
        "integrity": "sha256-SZLtQnRc0JkwqHab0VUVP7T3uBPSeYzxzDnpxPpUnHk="
      },
      {
        "virtualPath": "icudt_EFIGS.dat",
        "name": "icudt_EFIGS.tptq2av103.dat",
        "integrity": "sha256-8fItetYY8kQ0ww6oxwTLiT3oXlBwHKumbeP2pRF4yTc="
      },
      {
        "virtualPath": "icudt_no_CJK.dat",
        "name": "icudt_no_CJK.lfu7j35m59.dat",
        "integrity": "sha256-L7sV7NEYP37/Qr2FPCePo5cJqRgTXRwGHuwF5Q+0Nfs="
      }
    ],
    "coreAssembly": [
      {
        "virtualPath": "System.Runtime.InteropServices.JavaScript.dll",
        "name": "System.Runtime.InteropServices.JavaScript.3baesrx142.dll",
        "integrity": "sha256-r2OyjcuRWYUuj6qJ+EpSZStj6qlsZt3vS0R9sdUGTM8="
      },
      {
        "virtualPath": "System.Private.CoreLib.dll",
        "name": "System.Private.CoreLib.dlqw8dbd9u.dll",
        "integrity": "sha256-oZp+8ckNxdIzvnKSANpxnWFt1tg52XwqubJfWifpJTM="
      }
    ],
    "assembly": [
      {
        "virtualPath": "BlazorMonaco.dll",
        "name": "BlazorMonaco.5kgn2k4br2.dll",
        "integrity": "sha256-azr7uUonDjjxaCvj/fd9X9dbiRNGuuqGzG46//k9G0o="
      },
      {
        "virtualPath": "CSharpToBlockly.dll",
        "name": "CSharpToBlockly.o888968lv8.dll",
        "integrity": "sha256-uBzfuSWUJc1+gOKJRcplAXs+0Bve3mTe+MKGweC8l54="
      },
      {
        "virtualPath": "Humanizer.dll",
        "name": "Humanizer.cl0btz26i4.dll",
        "integrity": "sha256-QN/2+uvMbiur43ADhTUJsgUOgG7fPF8UH7uF/cDRvqc="
      },
      {
        "virtualPath": "ICSharpCode.Decompiler.dll",
        "name": "ICSharpCode.Decompiler.9h13tbttvn.dll",
        "integrity": "sha256-PYN7o2maVg1P2qmJyJ722wKQPEyHDl3VXRjKnDYPInA="
      },
      {
        "virtualPath": "IronBlock.dll",
        "name": "IronBlock.wlmqnogjtq.dll",
        "integrity": "sha256-9IukMnM2jJZHtcxZw82IpS/QYWWKHEZfEAbVhWOVtHU="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Authorization.dll",
        "name": "Microsoft.AspNetCore.Authorization.4kfahfnjd5.dll",
        "integrity": "sha256-ROpEqPHPGsA2vSjZvVEm7YWPpJ/wQoYFf8a2haJJRqU="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.dll",
        "name": "Microsoft.AspNetCore.Components.634stk17aw.dll",
        "integrity": "sha256-suB8A9Mz4t4V8qnLtcbmyGMQv98biKleQNHiZ8GMUUc="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.dll",
        "name": "Microsoft.AspNetCore.Components.Forms.n5fpj7wq0m.dll",
        "integrity": "sha256-Bfif5333vCS5bm0jxtQh2nOcbJu4ojGkdS0KpCRCGOU="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Web.dll",
        "name": "Microsoft.AspNetCore.Components.Web.pnaxgao9u9.dll",
        "integrity": "sha256-NewX2HlyvxAnbG2mgJsS6HcweyIFIaEqktyjyNyq/LI="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.dll",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.hwkmyclgp1.dll",
        "integrity": "sha256-r4pLt7ZeTv+ITkCqgtPX4xp3o4r4nmaCh1Dq/w27F8k="
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Metadata.dll",
        "name": "Microsoft.AspNetCore.Metadata.kqqz3qp6ci.dll",
        "integrity": "sha256-HA0NW/L0bvQfWtesEmEA5vvycHkO8Kn97gM/EorSSmI="
      },
      {
        "virtualPath": "Microsoft.Bcl.AsyncInterfaces.dll",
        "name": "Microsoft.Bcl.AsyncInterfaces.7ebd9nue78.dll",
        "integrity": "sha256-EcDo/GQZkQrOT1Xd0jMPE3NwT5lsMq5DNsPxHVidLDQ="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.AnalyzerUtilities.dll",
        "name": "Microsoft.CodeAnalysis.AnalyzerUtilities.dfnh3jj0fx.dll",
        "integrity": "sha256-JzALNJrgxVLMub6hi69VsfyZpRew1OFeVXr006S/8Rk="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.dll",
        "name": "Microsoft.CodeAnalysis.5v3qrypkq0.dll",
        "integrity": "sha256-Eel/9fuI4ap0TxEFWaO6Qzgp8AtaqZ9JR/wC7IQ3MF0="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.dll",
        "name": "Microsoft.CodeAnalysis.CSharp.byhuor2cif.dll",
        "integrity": "sha256-Yzpz6MUqpHlIi8nj+wO0OqbnuJ2hWF9ga12aL8NcORs="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.dll",
        "name": "Microsoft.CodeAnalysis.CSharp.Features.e5qcd92m1l.dll",
        "integrity": "sha256-nl8tg56Yc2bVKY78SNEeOhYPkqoH4FGnE2lVKkwOq08="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.dll",
        "name": "Microsoft.CodeAnalysis.CSharp.Scripting.49lomulnp8.dll",
        "integrity": "sha256-aGAOXyp6vv/YndIPbVYNpa9UmiW4Szg8nwUFzLrigRw="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.dll",
        "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.pl7ml194bp.dll",
        "integrity": "sha256-A8fbWr0ltHzJhz6utGEdbN4OYGMF7z+tLxcXMxkHkik="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Features.dll",
        "name": "Microsoft.CodeAnalysis.Features.r9ungwe4tz.dll",
        "integrity": "sha256-/2hU9O94KqVz6QS5fTfauHaQZ84Xzx9X5dmRLfzwJ1I="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Scripting.dll",
        "name": "Microsoft.CodeAnalysis.Scripting.mdlc7p275q.dll",
        "integrity": "sha256-xr0qhk8S6gzeUcG3tQxpkTwYhFqxVqARMOPZGqFW4JA="
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Workspaces.dll",
        "name": "Microsoft.CodeAnalysis.Workspaces.edw9o8d2cb.dll",
        "integrity": "sha256-3mu054QXs+GYfXsGzQdf8avqmZzOYcqm1ahPLMaKSgc="
      },
      {
        "virtualPath": "Microsoft.DiaSymReader.dll",
        "name": "Microsoft.DiaSymReader.hs1ke7nas6.dll",
        "integrity": "sha256-EYCsPJvmEe5Qhn8JBRppXAPtGdxPRty8Q4YchB+3dBs="
      },
      {
        "virtualPath": "Microsoft.Extensions.Caching.Abstractions.dll",
        "name": "Microsoft.Extensions.Caching.Abstractions.p85zvtnhtu.dll",
        "integrity": "sha256-SchZjU/Rxpo3WIvJHdizlvnxKoIKgFyAjGVc6e3/Rlk="
      },
      {
        "virtualPath": "Microsoft.Extensions.Caching.Memory.dll",
        "name": "Microsoft.Extensions.Caching.Memory.u0kn9z855q.dll",
        "integrity": "sha256-Hpr4zHKN1hh0psiOb8iVgEcSUNvg+3fBkN3wY7BQRB4="
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.dll",
        "name": "Microsoft.Extensions.Configuration.sjihaw7nyl.dll",
        "integrity": "sha256-2I3XomBYyPb6nmqXD7huNRAUTrZtGQEKzOCOqaIY7bk="
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.dll",
        "name": "Microsoft.Extensions.Configuration.Abstractions.addnrwyauu.dll",
        "integrity": "sha256-kkESqCMsPH+ToVrnF0Q5Ai6r4PiuaYn0OoXO51h5GqM="
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Binder.dll",
        "name": "Microsoft.Extensions.Configuration.Binder.3lpw0a214n.dll",
        "integrity": "sha256-hxGODxDHXz4GnvAnYNsk3HuiQ4sGmdF+OjjfH5c6pug="
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.FileExtensions.dll",
        "name": "Microsoft.Extensions.Configuration.FileExtensions.xfnlqjylo2.dll",
        "integrity": "sha256-E7CQJJ0sNVWy3q1xj8w7kWEyW73t9COShyL0FoiNuDc="
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Json.dll",
        "name": "Microsoft.Extensions.Configuration.Json.d2o6r3t66s.dll",
        "integrity": "sha256-qwkHQTy/5U3cqa1Ev+rgBS5Ag0ZJs/abUbuMODN+vLA="
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.dll",
        "name": "Microsoft.Extensions.DependencyInjection.64jpdpftuz.dll",
        "integrity": "sha256-Bo6SMW2mw0IDvd/tcSFzX4dO2GRGZU4Jhqpr7pWrhdM="
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.dll",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.rrg5yaq1l9.dll",
        "integrity": "sha256-J45E/5llDPwrkGL36wj3uVKHGxmiRiBHxloJhOUqdZo="
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.dll",
        "name": "Microsoft.Extensions.Diagnostics.1xvuo1acib.dll",
        "integrity": "sha256-FVmHL+LyivoyHixKxIj8QwmxSP8gSItJYH247wYuv84="
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.Abstractions.dll",
        "name": "Microsoft.Extensions.Diagnostics.Abstractions.znfl7mj9pk.dll",
        "integrity": "sha256-cc6bMK1fGFmqzOdDqoMZDBpj1aaGdUvIQlyESjC6jYg="
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Abstractions.dll",
        "name": "Microsoft.Extensions.FileProviders.Abstractions.62ijjx7ipr.dll",
        "integrity": "sha256-0hY9W2j5PEr2JWQ6R5hQEU6d80W3NOBLeBIOi6WURnE="
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Physical.dll",
        "name": "Microsoft.Extensions.FileProviders.Physical.j5eklms8i9.dll",
        "integrity": "sha256-p5GQ6qx8vPwnRDhbER6i3Cv/S9pBGrmtf1Fbdkp55lE="
      },
      {
        "virtualPath": "Microsoft.Extensions.FileSystemGlobbing.dll",
        "name": "Microsoft.Extensions.FileSystemGlobbing.49r4o3v8g6.dll",
        "integrity": "sha256-CKlYipd7neH5XnxAgE5tCz6geuD/jvbFAzAaEI+7d4o="
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.dll",
        "name": "Microsoft.Extensions.Logging.z5kdk7c6l8.dll",
        "integrity": "sha256-qQgM214BMd3GSHdrNUDthyO1V2J7BdUgtJS8M8ppfzU="
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.dll",
        "name": "Microsoft.Extensions.Logging.Abstractions.wxvefjgi4b.dll",
        "integrity": "sha256-NLQWiKfq8w9Xlmk1M5HcNhg6LU4KHgasf0xpNnHG5ys="
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.dll",
        "name": "Microsoft.Extensions.Options.hlm86yqjmg.dll",
        "integrity": "sha256-ZRJmtwY0o05enktz2PkjgmRDHuNKOKCJv0d3zQlD2ko="
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.ConfigurationExtensions.dll",
        "name": "Microsoft.Extensions.Options.ConfigurationExtensions.cmzcs9udlr.dll",
        "integrity": "sha256-VL+0BJAUMPhTGRBlI9nGw6bL6f46Mgj7QjH8FnB8O8g="
      },
      {
        "virtualPath": "Microsoft.Extensions.Primitives.dll",
        "name": "Microsoft.Extensions.Primitives.uen1i4ew05.dll",
        "integrity": "sha256-OhEIGk1FOuaLegqMv809i3HaxY14JrhhCmwRErFkoGM="
      },
      {
        "virtualPath": "Microsoft.Extensions.Validation.dll",
        "name": "Microsoft.Extensions.Validation.gpt35c6148.dll",
        "integrity": "sha256-3NFQwo98ZkWz8gtAkBl8E3xKMSyHX9JF92U6y/Ni1bA="
      },
      {
        "virtualPath": "Microsoft.JSInterop.dll",
        "name": "Microsoft.JSInterop.oudn41d68o.dll",
        "integrity": "sha256-IOIsWK3YmsOImxrByrw8vaWHrp5raNTEe/dSq2MwIHY="
      },
      {
        "virtualPath": "Microsoft.JSInterop.WebAssembly.dll",
        "name": "Microsoft.JSInterop.WebAssembly.f6octei4y0.dll",
        "integrity": "sha256-Z1pfOsj6FRt0n5+Y4eljWZL5fSsi2q1agwM5SI4+PJM="
      },
      {
        "virtualPath": "MudBlazor.dll",
        "name": "MudBlazor.sonnvr16vc.dll",
        "integrity": "sha256-VM2xalPWv+6IOcCzlmSpc5lqQu+vrcn3op+seJH/DC0="
      },
      {
        "virtualPath": "Newtonsoft.Json.dll",
        "name": "Newtonsoft.Json.m2k37x25ww.dll",
        "integrity": "sha256-oowlHf422IHp4kYuFxRBuLDsFW/j9FJgLJFJsbnv4Fs="
      },
      {
        "virtualPath": "NuGet.Versioning.dll",
        "name": "NuGet.Versioning.tfo07fwmbc.dll",
        "integrity": "sha256-RwF2WerrmHr8DUESLIg44KiXK6oIpOlENtQisvBfgTs="
      },
      {
        "virtualPath": "OmniSharp.Abstractions.dll",
        "name": "OmniSharp.Abstractions.q1ozm53f0p.dll",
        "integrity": "sha256-gqHW3q+MDzCpZBfHYUJpSkPE+XlCnBMTZleZT+E348I="
      },
      {
        "virtualPath": "OmniSharp.Roslyn.dll",
        "name": "OmniSharp.Roslyn.uvrzbzdua1.dll",
        "integrity": "sha256-FuEqobbgZpTImPEnN0XeR0V6DGQ0nRaCZn7UsvNTVJc="
      },
      {
        "virtualPath": "OmniSharp.Roslyn.CSharp.dll",
        "name": "OmniSharp.Roslyn.CSharp.pmv2zngpow.dll",
        "integrity": "sha256-oQslw/P98O5C1AQQHbmqDO+6l3cyQoDZo6cJcS9/jzw="
      },
      {
        "virtualPath": "OmniSharp.Shared.dll",
        "name": "OmniSharp.Shared.1efy42oh81.dll",
        "integrity": "sha256-l/FjoZACTNXaxq4C6nyW3neaWUa0HcSHNanrZD/XcEY="
      },
      {
        "virtualPath": "System.ComponentModel.Composition.dll",
        "name": "System.ComponentModel.Composition.5o729sr06e.dll",
        "integrity": "sha256-qyOp7krYRkOEeGXW6XXGdGvZEycN1j58qRJeTcJVZF8="
      },
      {
        "virtualPath": "System.Composition.AttributedModel.dll",
        "name": "System.Composition.AttributedModel.wd928deoaw.dll",
        "integrity": "sha256-BNjrFBngU/t1At2VLzl391sn3t5UGNX4fSHeFq29gxM="
      },
      {
        "virtualPath": "System.Composition.Convention.dll",
        "name": "System.Composition.Convention.tqjw6bvthv.dll",
        "integrity": "sha256-C9JMcpdyFpyZVZDQ+qkv/UKKnhfEGEXGFMSvulsMeH8="
      },
      {
        "virtualPath": "System.Composition.Hosting.dll",
        "name": "System.Composition.Hosting.6gg9uwo9lb.dll",
        "integrity": "sha256-eibpXg916AOttVXs/QK8pZpTOkhV22yGGj3vthnc6BM="
      },
      {
        "virtualPath": "System.Composition.Runtime.dll",
        "name": "System.Composition.Runtime.gvd4bzz1a1.dll",
        "integrity": "sha256-xBnj1R+e77H2/A+3zPm1rFzEt1+nUTHUrwx0JSkU6xA="
      },
      {
        "virtualPath": "System.Composition.TypedParts.dll",
        "name": "System.Composition.TypedParts.0j84otnpiz.dll",
        "integrity": "sha256-LGCb7Tu9K+gQRx4x42sSyzIaUPwlQejynB9ZyM+GnEE="
      },
      {
        "virtualPath": "System.Security.Permissions.dll",
        "name": "System.Security.Permissions.0bgkyyb5fs.dll",
        "integrity": "sha256-jKmbTXbScI0nBA2C2HyfK+smmH4oMUauprwnXZLolc4="
      },
      {
        "virtualPath": "Microsoft.CSharp.dll",
        "name": "Microsoft.CSharp.f70uow97if.dll",
        "integrity": "sha256-dbv1CogL1V35iP55+nJ20fpITfuh6TCQzegwmYqBM4c="
      },
      {
        "virtualPath": "Microsoft.VisualBasic.Core.dll",
        "name": "Microsoft.VisualBasic.Core.8a0dpzdkgj.dll",
        "integrity": "sha256-sDdrTGqSP6BG/44rrYOkFy6GGwkSOuCsPH2PSn/NDb8="
      },
      {
        "virtualPath": "Microsoft.VisualBasic.dll",
        "name": "Microsoft.VisualBasic.s16eoucqa0.dll",
        "integrity": "sha256-IKaxvw2uoBsJkbzFYz+MpuIuIIs6MhUkOmGSe5ld7Vk="
      },
      {
        "virtualPath": "Microsoft.Win32.Primitives.dll",
        "name": "Microsoft.Win32.Primitives.sq6y577wjl.dll",
        "integrity": "sha256-pGfrJFA7iGE8Vu+J8hdjnHi0Q5m64MGS58Thh9fep7k="
      },
      {
        "virtualPath": "Microsoft.Win32.Registry.dll",
        "name": "Microsoft.Win32.Registry.67mu20p2gp.dll",
        "integrity": "sha256-HuLdywk+atXaNWddh3qFbmxiRjSHPQ04bU2qXI4xW5Y="
      },
      {
        "virtualPath": "System.AppContext.dll",
        "name": "System.AppContext.c8bbuz6jsa.dll",
        "integrity": "sha256-ZIgl/urW99e+DQ0OxgwOs3CMlaxF8i47OF7C8Hw/ohw="
      },
      {
        "virtualPath": "System.Buffers.dll",
        "name": "System.Buffers.83zi99cwe4.dll",
        "integrity": "sha256-JK9O5rtDJgYuEe1Ba2H+mLmaRPLCw8CAmLY2ppWnfdw="
      },
      {
        "virtualPath": "System.Collections.Concurrent.dll",
        "name": "System.Collections.Concurrent.p8ij3p4cyb.dll",
        "integrity": "sha256-GQr6hHR1eYALteEPqKDHBbUL0xWbsprCbVbjeNotdrQ="
      },
      {
        "virtualPath": "System.Collections.Immutable.dll",
        "name": "System.Collections.Immutable.eysqx4zjom.dll",
        "integrity": "sha256-6qnGSnszT1jh6GG5adFKl7+2YSf8EOlDXGyHNf3dcBs="
      },
      {
        "virtualPath": "System.Collections.NonGeneric.dll",
        "name": "System.Collections.NonGeneric.i8hqk7gkqk.dll",
        "integrity": "sha256-wunFYz0R/uNQ1s59yNUhGeoCiSJhp0tdNbSPPo6iPSc="
      },
      {
        "virtualPath": "System.Collections.Specialized.dll",
        "name": "System.Collections.Specialized.ds6b1nn2ji.dll",
        "integrity": "sha256-47uH3lPkK57x4KyKFfTB1XLI31UOgAmcJHaNYJ7qXno="
      },
      {
        "virtualPath": "System.Collections.dll",
        "name": "System.Collections.rgiffyd1cn.dll",
        "integrity": "sha256-xa1gG6AKG7eypdHvtQdx38FEwEWxmCeBDaiXOETDk8Q="
      },
      {
        "virtualPath": "System.ComponentModel.Annotations.dll",
        "name": "System.ComponentModel.Annotations.8040pogm9s.dll",
        "integrity": "sha256-uFL8NQHhhEySI4pDkbFSCCzLF8O5BBrgho2joBHnZdk="
      },
      {
        "virtualPath": "System.ComponentModel.DataAnnotations.dll",
        "name": "System.ComponentModel.DataAnnotations.05ou1lfdzv.dll",
        "integrity": "sha256-tBp5NOVOQpwiS1J8Y8dgSa/LsnUqRfsLyy0vBx7p5CE="
      },
      {
        "virtualPath": "System.ComponentModel.EventBasedAsync.dll",
        "name": "System.ComponentModel.EventBasedAsync.b3trfxx2mi.dll",
        "integrity": "sha256-B+8euGnv1OVutd0ed+qakhyD0Fb7v3ZAViJIgZ6abCo="
      },
      {
        "virtualPath": "System.ComponentModel.Primitives.dll",
        "name": "System.ComponentModel.Primitives.cbol5e38nz.dll",
        "integrity": "sha256-WLu26EdTQiVHMCEQTqbFVnknRxXziZ1Bume+Wf+UaOU="
      },
      {
        "virtualPath": "System.ComponentModel.TypeConverter.dll",
        "name": "System.ComponentModel.TypeConverter.tuocuq1nqn.dll",
        "integrity": "sha256-1V7LlAIrFkEKA1HKMNb9+QfyKfA8mflpoTh7Plh10L8="
      },
      {
        "virtualPath": "System.ComponentModel.dll",
        "name": "System.ComponentModel.mr3y0kxsv7.dll",
        "integrity": "sha256-bthXC2j3OreOYaThvukaDj4Z2aOGmValFga7PfizzmQ="
      },
      {
        "virtualPath": "System.Configuration.dll",
        "name": "System.Configuration.udgl9cdwy4.dll",
        "integrity": "sha256-zpCM+XsF+zmkvuEYdhdhelBhd++th6WymBtkGBhh6Fg="
      },
      {
        "virtualPath": "System.Console.dll",
        "name": "System.Console.l5kj40f48g.dll",
        "integrity": "sha256-yWBHtEQEq1IVxIOXjg9ItqdyUmL1sb3NTDGpwwnmVXk="
      },
      {
        "virtualPath": "System.Core.dll",
        "name": "System.Core.uu7p50nge4.dll",
        "integrity": "sha256-+nbx5PfecqHK4iJ6ueeIZh3flFH2cs8O72iRG8yL/DQ="
      },
      {
        "virtualPath": "System.Data.Common.dll",
        "name": "System.Data.Common.bwmsnmaqco.dll",
        "integrity": "sha256-6xGRtOFsH2xUqJVPU6zc2D3XLLJI4X0/EV4ZPP1U2lc="
      },
      {
        "virtualPath": "System.Data.DataSetExtensions.dll",
        "name": "System.Data.DataSetExtensions.m8fi9631o6.dll",
        "integrity": "sha256-WvHAwboIA3OpIvdtb1/9jT0TxC6fvSf707RT1NPduM0="
      },
      {
        "virtualPath": "System.Data.dll",
        "name": "System.Data.tyrrtqk7tz.dll",
        "integrity": "sha256-Vav5Fhzx5/oAAexJ9p0f71rBjHmaIy/Fcrnm1B23lVs="
      },
      {
        "virtualPath": "System.Diagnostics.Contracts.dll",
        "name": "System.Diagnostics.Contracts.vlhrsle7db.dll",
        "integrity": "sha256-40GAScDzPoENy8Rab8GO2092aC/sCQ6C1L/5qPplVdg="
      },
      {
        "virtualPath": "System.Diagnostics.Debug.dll",
        "name": "System.Diagnostics.Debug.y8emcfxiot.dll",
        "integrity": "sha256-XlYvqWFr4imWDmRGiUKP9W1oK+HuEg2y+gQCF3zRg/A="
      },
      {
        "virtualPath": "System.Diagnostics.DiagnosticSource.dll",
        "name": "System.Diagnostics.DiagnosticSource.yihjlb3u1y.dll",
        "integrity": "sha256-etBeBN+qe/B3DuGXO+H8mogZQrg47IFOCtC9llJhlZ0="
      },
      {
        "virtualPath": "System.Diagnostics.FileVersionInfo.dll",
        "name": "System.Diagnostics.FileVersionInfo.ynrxxwe9t5.dll",
        "integrity": "sha256-spSxEXvkKL21ocq/miYIF8V5Zp4SXJM/ltGifWRaxA8="
      },
      {
        "virtualPath": "System.Diagnostics.Process.dll",
        "name": "System.Diagnostics.Process.97xz1ypdfd.dll",
        "integrity": "sha256-1ctBP6jL35RGhrfeeO5F3NfO0lv7V73yhWbdz8HTupw="
      },
      {
        "virtualPath": "System.Diagnostics.StackTrace.dll",
        "name": "System.Diagnostics.StackTrace.2kseaj0sk3.dll",
        "integrity": "sha256-7gEs/Tk4Q6mh+wkvGpHHkrJcHjjBaoEeOkmI+zIM/yU="
      },
      {
        "virtualPath": "System.Diagnostics.TextWriterTraceListener.dll",
        "name": "System.Diagnostics.TextWriterTraceListener.v4wdy0swzi.dll",
        "integrity": "sha256-7wUqdK7CGVF5j7YU0IHD+TC7LX+ieUgCUBBo/moIECk="
      },
      {
        "virtualPath": "System.Diagnostics.Tools.dll",
        "name": "System.Diagnostics.Tools.u8jgle8dzi.dll",
        "integrity": "sha256-brJ3cFaa/ZRnA1zZjTC8YlgsJIxnKa2rkAA7HVWu9bM="
      },
      {
        "virtualPath": "System.Diagnostics.TraceSource.dll",
        "name": "System.Diagnostics.TraceSource.40ycfzd5bo.dll",
        "integrity": "sha256-JCIUDt/iXy87r0dkKqM65P5XeDP7CTN86lqTEvlrzps="
      },
      {
        "virtualPath": "System.Diagnostics.Tracing.dll",
        "name": "System.Diagnostics.Tracing.2w5fjynjg7.dll",
        "integrity": "sha256-bklf3w7rIcK6rAN9ACBnM9IGB9wDhNCMbEryi62fRUQ="
      },
      {
        "virtualPath": "System.Drawing.Primitives.dll",
        "name": "System.Drawing.Primitives.ij5goanc4z.dll",
        "integrity": "sha256-8o9dhjOFmquPgEyvKMMrWUcfhaKuOCpx4q/2k4qD36o="
      },
      {
        "virtualPath": "System.Drawing.dll",
        "name": "System.Drawing.qz55x9g1nx.dll",
        "integrity": "sha256-lnJr/6JmoPcWM1JffNB+V0JEA694UEokqbLv7nht0uo="
      },
      {
        "virtualPath": "System.Dynamic.Runtime.dll",
        "name": "System.Dynamic.Runtime.pzi6p910po.dll",
        "integrity": "sha256-pTKdV+2n05l24HI07fIo0On10CfQJmzF1d1E++V6TrA="
      },
      {
        "virtualPath": "System.Formats.Asn1.dll",
        "name": "System.Formats.Asn1.zswsbdvu7i.dll",
        "integrity": "sha256-E0Qmfk83vzEN1DY83tlLDqQetvjVU1K2JtRUQ7MVO6s="
      },
      {
        "virtualPath": "System.Formats.Tar.dll",
        "name": "System.Formats.Tar.hj4mh1wvg6.dll",
        "integrity": "sha256-fdUBOxWOM08Q2fUpi3rk7GMUx5hOgD/fJ+vwX8TgXvo="
      },
      {
        "virtualPath": "System.Globalization.Calendars.dll",
        "name": "System.Globalization.Calendars.yb7l0qnxv1.dll",
        "integrity": "sha256-oo+4W8KUTuyEjHLtRABdgHyEd7GRaq54kBgabtTSNH4="
      },
      {
        "virtualPath": "System.Globalization.Extensions.dll",
        "name": "System.Globalization.Extensions.dvhn7yguas.dll",
        "integrity": "sha256-x5ZbrHqAvNLPEGwLZqTYX4tCVekD8ndZqs9wergRFS8="
      },
      {
        "virtualPath": "System.Globalization.dll",
        "name": "System.Globalization.y6ilgzbuou.dll",
        "integrity": "sha256-pgRx+RQmwfy6KwUI5ndrkoPnxcsnKY7x5MVhnlpYOgg="
      },
      {
        "virtualPath": "System.IO.Compression.Brotli.dll",
        "name": "System.IO.Compression.Brotli.acmr269ymt.dll",
        "integrity": "sha256-JiwDaTqChsqWISBxsmXXuo+58TK8G4LoS1Kxw6tF35Q="
      },
      {
        "virtualPath": "System.IO.Compression.FileSystem.dll",
        "name": "System.IO.Compression.FileSystem.l2arjj5pkz.dll",
        "integrity": "sha256-Q+XLFdZymJDVooL9/BEOBNU1tZ47of7WKJJaNZEWnyE="
      },
      {
        "virtualPath": "System.IO.Compression.ZipFile.dll",
        "name": "System.IO.Compression.ZipFile.7tbzjyieny.dll",
        "integrity": "sha256-dX4wAzLhM+/jP67DYSsaJ3pR3TZCcQ5AZ9+cijmH8Z0="
      },
      {
        "virtualPath": "System.IO.Compression.dll",
        "name": "System.IO.Compression.2kn7uaqrhk.dll",
        "integrity": "sha256-AhmqTl4umSMpUYegiEJ57ZEJSLRCmNeovMiTpVuNeMk="
      },
      {
        "virtualPath": "System.IO.FileSystem.AccessControl.dll",
        "name": "System.IO.FileSystem.AccessControl.x1sk4zmnud.dll",
        "integrity": "sha256-+yRhiqAV60vvJYk6joSqgUXWXBICQMal29s/YA8ndFs="
      },
      {
        "virtualPath": "System.IO.FileSystem.DriveInfo.dll",
        "name": "System.IO.FileSystem.DriveInfo.sqy03owel5.dll",
        "integrity": "sha256-HI2QkCsPdFmHZoe1puE6zh+oD6FRxkaew1j+VVeAmmc="
      },
      {
        "virtualPath": "System.IO.FileSystem.Primitives.dll",
        "name": "System.IO.FileSystem.Primitives.on2hcsnreb.dll",
        "integrity": "sha256-TCyh0QHiIT+vNtzsVMlz6YoFa54pSGFA6fqWnQfeDKk="
      },
      {
        "virtualPath": "System.IO.FileSystem.Watcher.dll",
        "name": "System.IO.FileSystem.Watcher.vnkz5v41y8.dll",
        "integrity": "sha256-W9RfTaHOrP80ijK8sxBAVfDfwm+9zKA14+c5CUH1LRc="
      },
      {
        "virtualPath": "System.IO.FileSystem.dll",
        "name": "System.IO.FileSystem.dkh25wrowu.dll",
        "integrity": "sha256-k+XkTe89T42SSGWXcZC+BYvSO5ozk2ijA1FZV5KEN0Q="
      },
      {
        "virtualPath": "System.IO.IsolatedStorage.dll",
        "name": "System.IO.IsolatedStorage.hspvkz3dkv.dll",
        "integrity": "sha256-r/v9xX9iNvixNnc/izyOYa2a+8ER3PElo8+jj2L8bRk="
      },
      {
        "virtualPath": "System.IO.MemoryMappedFiles.dll",
        "name": "System.IO.MemoryMappedFiles.l9og8gh0on.dll",
        "integrity": "sha256-J8nYp2uUBL+tXW6sWqjwBqeu9JxfPo0jqsaYWXFAlw8="
      },
      {
        "virtualPath": "System.IO.Pipelines.dll",
        "name": "System.IO.Pipelines.bz3jmikgi1.dll",
        "integrity": "sha256-5ziIZfhEgLtHMyPQVg6+9JRxXaTF8dfUPd9DKDiG5uw="
      },
      {
        "virtualPath": "System.IO.Pipes.AccessControl.dll",
        "name": "System.IO.Pipes.AccessControl.g1c8vyva8h.dll",
        "integrity": "sha256-9KWnmspwIbxriSYgr0tnFpONBLCmQvN1dgj9EYjsJ3M="
      },
      {
        "virtualPath": "System.IO.Pipes.dll",
        "name": "System.IO.Pipes.drti0759br.dll",
        "integrity": "sha256-KXOaglh2vexSBC1dFLJdYkzAU/4n/QZvhFUwSJWGe9E="
      },
      {
        "virtualPath": "System.IO.UnmanagedMemoryStream.dll",
        "name": "System.IO.UnmanagedMemoryStream.r9zv0b4x7x.dll",
        "integrity": "sha256-sa/22b317vCJ8TICCDKJeU/UPMk2paDsGur14A+vr6Q="
      },
      {
        "virtualPath": "System.IO.dll",
        "name": "System.IO.jm7cegb0ni.dll",
        "integrity": "sha256-ZZBBwRazzu2brF7cygfhnUb8J00zfpMUzf1Vkmu3mzA="
      },
      {
        "virtualPath": "System.Linq.AsyncEnumerable.dll",
        "name": "System.Linq.AsyncEnumerable.0ankgu86hn.dll",
        "integrity": "sha256-KAUdUVoS+DzMEvq2Nh8hFLRXloJL8F9Dae/tLoQt22M="
      },
      {
        "virtualPath": "System.Linq.Expressions.dll",
        "name": "System.Linq.Expressions.1q0qdfh8wt.dll",
        "integrity": "sha256-KV8V0amRKlE+XrG9KZG9PqCZgRQYBNrwT81qyapan/I="
      },
      {
        "virtualPath": "System.Linq.Parallel.dll",
        "name": "System.Linq.Parallel.k6v7a5l7t8.dll",
        "integrity": "sha256-nCcoNRal36oWJcnbRGpEuoOhrDX/TQsHIWL4Xh6KDto="
      },
      {
        "virtualPath": "System.Linq.Queryable.dll",
        "name": "System.Linq.Queryable.t2vjh4d4ft.dll",
        "integrity": "sha256-FTUsqr3xOURQamVDykjyrnA6jlDRqe59rQ60yOm6btw="
      },
      {
        "virtualPath": "System.Linq.dll",
        "name": "System.Linq.qmasavlu24.dll",
        "integrity": "sha256-LuWnG6PgE2fv/oaRQ7ciM7ptB8P7UV0QTm6x1D+xuzU="
      },
      {
        "virtualPath": "System.Memory.dll",
        "name": "System.Memory.sqsypo3d5l.dll",
        "integrity": "sha256-BE/IA9hc4mZFbRuyjyabC0vQhuYQgtYAC8gHjvPbR98="
      },
      {
        "virtualPath": "System.Net.Http.Json.dll",
        "name": "System.Net.Http.Json.mhihfze9cm.dll",
        "integrity": "sha256-Jo0H6L+LpNC5wd9XW2itcbCkPHKQ2TJcji0sN73f25U="
      },
      {
        "virtualPath": "System.Net.Http.dll",
        "name": "System.Net.Http.s99cayeofd.dll",
        "integrity": "sha256-EFTBuXg5UmT8ZLeVkewKpxVp8e5bR7oy+zLwhBsrw3c="
      },
      {
        "virtualPath": "System.Net.HttpListener.dll",
        "name": "System.Net.HttpListener.tw8zoex4zl.dll",
        "integrity": "sha256-I8hJagCTNKa6X21k+WTM5CjzwMQA5vQL6iOaxpA1rH8="
      },
      {
        "virtualPath": "System.Net.Mail.dll",
        "name": "System.Net.Mail.nq76btwv15.dll",
        "integrity": "sha256-r6uzMVFNzp5qyTndgEgZyBUlUifKdkgj1/cpqGAxhk8="
      },
      {
        "virtualPath": "System.Net.NameResolution.dll",
        "name": "System.Net.NameResolution.dmy3tzjym9.dll",
        "integrity": "sha256-BStrIMVeYigY+GXVxrAyOedBOMGqY1MBF8JHhboIoyo="
      },
      {
        "virtualPath": "System.Net.NetworkInformation.dll",
        "name": "System.Net.NetworkInformation.2r1j51vkqn.dll",
        "integrity": "sha256-nkgeHnWw+z4YYLoy8exjV4xuDkNDAqVdOihyureMgMk="
      },
      {
        "virtualPath": "System.Net.Ping.dll",
        "name": "System.Net.Ping.3yk8tt3cj5.dll",
        "integrity": "sha256-Cx0B9yBo/Dg27Ru+ZF9+aoT0uV9GyZvRAfXUt5/ylqA="
      },
      {
        "virtualPath": "System.Net.Primitives.dll",
        "name": "System.Net.Primitives.kizdhrkqmk.dll",
        "integrity": "sha256-9E2dUaLB5r2RofBmS452dyNvCymFhQcIBnMqnlVTu0Q="
      },
      {
        "virtualPath": "System.Net.Quic.dll",
        "name": "System.Net.Quic.q2yusaf5ec.dll",
        "integrity": "sha256-/sNKsqHu233xSv817442ozZuYAEywOTS4wDZTWnES3E="
      },
      {
        "virtualPath": "System.Net.Requests.dll",
        "name": "System.Net.Requests.f7cqm4o1nn.dll",
        "integrity": "sha256-tRlEfjI4A/rK7pYIe9QXWPBDMbU8sXVJMd2elB/Dj38="
      },
      {
        "virtualPath": "System.Net.Security.dll",
        "name": "System.Net.Security.tdgru9q5gg.dll",
        "integrity": "sha256-T/K8kqoYJr2WG6zOrD4UcSt6b5R2QqDtveUotUn8jfU="
      },
      {
        "virtualPath": "System.Net.ServerSentEvents.dll",
        "name": "System.Net.ServerSentEvents.jx9knujngc.dll",
        "integrity": "sha256-ufHu3L603C6F2m9k9YJdgqlywU9yjRWvLYY1O2+k8Nw="
      },
      {
        "virtualPath": "System.Net.ServicePoint.dll",
        "name": "System.Net.ServicePoint.zhur8yyuq1.dll",
        "integrity": "sha256-2bybf9Qi8RLW1pJJdijLsAtpyKGWS0MjdX1Vtg2/yxE="
      },
      {
        "virtualPath": "System.Net.Sockets.dll",
        "name": "System.Net.Sockets.7chyx7zkra.dll",
        "integrity": "sha256-uQbAEh6FNfSWX6Y4SUG02LImWmGpMwU9uQ2mdrpqnIw="
      },
      {
        "virtualPath": "System.Net.WebClient.dll",
        "name": "System.Net.WebClient.7lgwg7ai53.dll",
        "integrity": "sha256-+8cTGbIKcUR0Deje9weGYCJj37C+DptDxYLrfTW5Z8E="
      },
      {
        "virtualPath": "System.Net.WebHeaderCollection.dll",
        "name": "System.Net.WebHeaderCollection.812mcny59x.dll",
        "integrity": "sha256-zFusO5rxBcBy2oV5NnTHUhTfOvhoNsoe0k85TmAinYU="
      },
      {
        "virtualPath": "System.Net.WebProxy.dll",
        "name": "System.Net.WebProxy.t8w1nv2mts.dll",
        "integrity": "sha256-fUx93CVftddEt/lssWF7TrfO3t3gUqzz4RPOkho+wmM="
      },
      {
        "virtualPath": "System.Net.WebSockets.Client.dll",
        "name": "System.Net.WebSockets.Client.ieemesj01m.dll",
        "integrity": "sha256-auDHGoCO3+Rc4Fw78Pedkbfn05KF+NDtPH0a1VqBvFU="
      },
      {
        "virtualPath": "System.Net.WebSockets.dll",
        "name": "System.Net.WebSockets.s4kkpg0ig1.dll",
        "integrity": "sha256-FOSRys7zMmWYVhuB3PlH3SUOQkXqYoE5Ls7QtPVkSeI="
      },
      {
        "virtualPath": "System.Net.dll",
        "name": "System.Net.x24ohebl8u.dll",
        "integrity": "sha256-VzyFif0w24Cg53USVbzmHyn8RJWN+uyydwGWVIIlpdA="
      },
      {
        "virtualPath": "System.Numerics.Vectors.dll",
        "name": "System.Numerics.Vectors.6e5b85so8r.dll",
        "integrity": "sha256-8hNmkKpGAimKBSlXCPMiDay/+KCSzRQBkNFsM+aEhY4="
      },
      {
        "virtualPath": "System.Numerics.dll",
        "name": "System.Numerics.g7rhsqmi3q.dll",
        "integrity": "sha256-/McVySmBUcVucoyUohp+392witZRj4j5B9qu3OWBWXo="
      },
      {
        "virtualPath": "System.ObjectModel.dll",
        "name": "System.ObjectModel.d9zw4slns3.dll",
        "integrity": "sha256-fwE8eLPp6KLIH7X2B76KT0n55mWeYSdJkkMatVgvypc="
      },
      {
        "virtualPath": "System.Private.DataContractSerialization.dll",
        "name": "System.Private.DataContractSerialization.op88m9741o.dll",
        "integrity": "sha256-5BfjLD5yWsT38/WgYoBPo/LO4msKdkS9AG16rrGhlJs="
      },
      {
        "virtualPath": "System.Private.Uri.dll",
        "name": "System.Private.Uri.ju2q7dyfmp.dll",
        "integrity": "sha256-FdQ/5+F1dNukX4WW4hKTIrIv3sfnT/N0t6LS/C1wZWo="
      },
      {
        "virtualPath": "System.Private.Xml.Linq.dll",
        "name": "System.Private.Xml.Linq.u9sb5vjfea.dll",
        "integrity": "sha256-HqtzNdnXpG3Hy/SPI5kC8Eej7EoVWteD06FTGFX+jWE="
      },
      {
        "virtualPath": "System.Private.Xml.dll",
        "name": "System.Private.Xml.e2kvmo420s.dll",
        "integrity": "sha256-qpJdYyJGlMqEiZUy4AsQTytaXPK56cesO31MDvoo4wY="
      },
      {
        "virtualPath": "System.Reflection.DispatchProxy.dll",
        "name": "System.Reflection.DispatchProxy.6y263kbpfy.dll",
        "integrity": "sha256-bvcmhDrFXRovwWUM+udg4UD668BE/hRQB5lhR0nnGXk="
      },
      {
        "virtualPath": "System.Reflection.Emit.ILGeneration.dll",
        "name": "System.Reflection.Emit.ILGeneration.jo8dwv9zid.dll",
        "integrity": "sha256-M7lHdr9Wpj97yVEbtCbUsLuPgbZZr5d5j0n+cYc+uLc="
      },
      {
        "virtualPath": "System.Reflection.Emit.Lightweight.dll",
        "name": "System.Reflection.Emit.Lightweight.m1wv17avu7.dll",
        "integrity": "sha256-+jAFkWJh5NZNlbtV0S1AE5VUC8xBqnpENpyIpIc6Nqg="
      },
      {
        "virtualPath": "System.Reflection.Emit.dll",
        "name": "System.Reflection.Emit.khnesvh03j.dll",
        "integrity": "sha256-mAlPSVIQVwbOeW1HyqTwEmOA2/G1UsaLzSoM20yeNVg="
      },
      {
        "virtualPath": "System.Reflection.Extensions.dll",
        "name": "System.Reflection.Extensions.5sattgbjhi.dll",
        "integrity": "sha256-1cjzCJoNM2QH1tcyA0r7OhMEmz0NJ5acDMQaWI7o7+s="
      },
      {
        "virtualPath": "System.Reflection.Metadata.dll",
        "name": "System.Reflection.Metadata.q2n1l16rpd.dll",
        "integrity": "sha256-EiT+dG0QC8doTa8MeTW/XK51KdbDa7ldjwx0o3RoqjU="
      },
      {
        "virtualPath": "System.Reflection.Primitives.dll",
        "name": "System.Reflection.Primitives.u80ukm33im.dll",
        "integrity": "sha256-QgeemDmixbLp/CdQjs/ZCUNbjXQfo0D50evuwETSBx8="
      },
      {
        "virtualPath": "System.Reflection.TypeExtensions.dll",
        "name": "System.Reflection.TypeExtensions.xujop323m4.dll",
        "integrity": "sha256-dwD/kAdWT+aM9iXB7JDig45T43iQsZ0y2WFhGouLpUA="
      },
      {
        "virtualPath": "System.Reflection.dll",
        "name": "System.Reflection.1uelv7w5e6.dll",
        "integrity": "sha256-WXmzs89ynXZJ6Cq7/9wIbLlR6uUZ/Yg5t1tXjsZJLlE="
      },
      {
        "virtualPath": "System.Resources.Reader.dll",
        "name": "System.Resources.Reader.ynnq6eialw.dll",
        "integrity": "sha256-sqdrGQKYRPm01Oh64NVX8nUWMB9Yadsvd+vtBsY3Z08="
      },
      {
        "virtualPath": "System.Resources.ResourceManager.dll",
        "name": "System.Resources.ResourceManager.h9qb4q4ju6.dll",
        "integrity": "sha256-S3ormUarRhH0rXuXv3cHDB916v8T7kR7D6JDeHw0VDM="
      },
      {
        "virtualPath": "System.Resources.Writer.dll",
        "name": "System.Resources.Writer.p1igbzuldj.dll",
        "integrity": "sha256-XTbC+E1ZefcVrZdInKqdAwemfgQOOQ7ncSi6Z6wDKy0="
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.Unsafe.dll",
        "name": "System.Runtime.CompilerServices.Unsafe.ibx4pyo8d6.dll",
        "integrity": "sha256-Un0hTFKTddOstt1iDqiyX8fBJwLvxPIPnO6ge6qPmCc="
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.VisualC.dll",
        "name": "System.Runtime.CompilerServices.VisualC.rjdt5mykmb.dll",
        "integrity": "sha256-Kbkh6HfdDlCHQI8TLW/d/6UTf+lotOEBoCt0YnYzsAA="
      },
      {
        "virtualPath": "System.Runtime.Extensions.dll",
        "name": "System.Runtime.Extensions.fzvw3qj59k.dll",
        "integrity": "sha256-FZt4bxB5A8ne+uuzUuZwoakbhWT0EX1o3IHLUpTAIkI="
      },
      {
        "virtualPath": "System.Runtime.Handles.dll",
        "name": "System.Runtime.Handles.b92vjlxn6s.dll",
        "integrity": "sha256-0askasatxw3WFHw6gIe9dyzzzYvk6Lw2oI7x565hEEY="
      },
      {
        "virtualPath": "System.Runtime.InteropServices.RuntimeInformation.dll",
        "name": "System.Runtime.InteropServices.RuntimeInformation.at7oxn1h7h.dll",
        "integrity": "sha256-jgrwxlS3pEd/nZ5DUbf5IjI4u87FkLOf5RjVR1/LA00="
      },
      {
        "virtualPath": "System.Runtime.InteropServices.dll",
        "name": "System.Runtime.InteropServices.1ul8emd3ux.dll",
        "integrity": "sha256-iZYXGOjlZlJpThUMobxTtzO6BeGbhvNtahGpBZkhVq0="
      },
      {
        "virtualPath": "System.Runtime.Intrinsics.dll",
        "name": "System.Runtime.Intrinsics.ei44gvzemm.dll",
        "integrity": "sha256-1ovLO31ZCN1ORVlJ+Mpxen8Fv9b6gAPILFAUcX18nYg="
      },
      {
        "virtualPath": "System.Runtime.Loader.dll",
        "name": "System.Runtime.Loader.jur8jwo2q3.dll",
        "integrity": "sha256-+7FN2CttiRQYqDqxkyrKwXmKxqok03JZnx7ppRcL3SI="
      },
      {
        "virtualPath": "System.Runtime.Numerics.dll",
        "name": "System.Runtime.Numerics.fb07eioh3c.dll",
        "integrity": "sha256-WxPK3ev0qNxJDMTVn1+UDOoOx05jKUfG70x9kFVrM+U="
      },
      {
        "virtualPath": "System.Runtime.Serialization.Formatters.dll",
        "name": "System.Runtime.Serialization.Formatters.v9gq1dqw6s.dll",
        "integrity": "sha256-42mcudzUDi0rmtRyas//JRUKFJ2xBAhf8IvMn3x9lQc="
      },
      {
        "virtualPath": "System.Runtime.Serialization.Json.dll",
        "name": "System.Runtime.Serialization.Json.saqxagugcv.dll",
        "integrity": "sha256-nJLNZELlDdzIfzQ2en5ebpPDZ+LQPdG+KpszvLT2CxU="
      },
      {
        "virtualPath": "System.Runtime.Serialization.Primitives.dll",
        "name": "System.Runtime.Serialization.Primitives.gdu7nwnxbe.dll",
        "integrity": "sha256-fMN070fG1Q/OSW5yODgzQsshw/c8FTbqgKSHwcXkl9M="
      },
      {
        "virtualPath": "System.Runtime.Serialization.Xml.dll",
        "name": "System.Runtime.Serialization.Xml.437ir3n5x7.dll",
        "integrity": "sha256-YItPdBX6sHp52MiP3d0i/IB3KAxonTITm1RAAs6C+FA="
      },
      {
        "virtualPath": "System.Runtime.Serialization.dll",
        "name": "System.Runtime.Serialization.y5m4y5kmn6.dll",
        "integrity": "sha256-ymDaP3MU4WnkVo8Fa4jCk4PpAGrrxmvWlKic6fylMRI="
      },
      {
        "virtualPath": "System.Runtime.dll",
        "name": "System.Runtime.wrkgt9l8q4.dll",
        "integrity": "sha256-LB4713UGtcgySDloX4iX1565pJptwOQdnPOFiImRTvU="
      },
      {
        "virtualPath": "System.Security.AccessControl.dll",
        "name": "System.Security.AccessControl.306kphhn39.dll",
        "integrity": "sha256-Y8iy//P9LFkHo3gC2ihQn2h/5fBok36F6UnHauOkozs="
      },
      {
        "virtualPath": "System.Security.Claims.dll",
        "name": "System.Security.Claims.4fpvs46ne6.dll",
        "integrity": "sha256-cN5GsEL7BLRvO+GCqg8GGzMT+Igti9zLGIhW7oxtdmg="
      },
      {
        "virtualPath": "System.Security.Cryptography.Algorithms.dll",
        "name": "System.Security.Cryptography.Algorithms.fphjb8czx9.dll",
        "integrity": "sha256-nZR2xqaTVhPtZMbWrV/s/5r0fa7gkih+NEeqs8tLDWo="
      },
      {
        "virtualPath": "System.Security.Cryptography.Cng.dll",
        "name": "System.Security.Cryptography.Cng.o72pyss4ak.dll",
        "integrity": "sha256-dOkLkUYXE+pYGlqAAbdYNM79QClzxuEvrVOx98ssyuA="
      },
      {
        "virtualPath": "System.Security.Cryptography.Csp.dll",
        "name": "System.Security.Cryptography.Csp.vrwhbz8y9n.dll",
        "integrity": "sha256-Kxcdf6DR0Epn4ZkKiyc6UXXydHgUYSseloZQUYyEYTs="
      },
      {
        "virtualPath": "System.Security.Cryptography.Encoding.dll",
        "name": "System.Security.Cryptography.Encoding.46hmpmiqnr.dll",
        "integrity": "sha256-lI5gACao8onlPxXAadeE/E1T/bpt451+70FWvIkrZYc="
      },
      {
        "virtualPath": "System.Security.Cryptography.OpenSsl.dll",
        "name": "System.Security.Cryptography.OpenSsl.ez1k1lsdm3.dll",
        "integrity": "sha256-Clx4YXTj5uZlmlIQFhq/ihU1xrsf3/Y6nQZjOjOBPnk="
      },
      {
        "virtualPath": "System.Security.Cryptography.Primitives.dll",
        "name": "System.Security.Cryptography.Primitives.3psyhlpo3c.dll",
        "integrity": "sha256-x3ptIhTwsbg0vecoRq7Rf8ECqgWy1PEVPPEKIVDMGSc="
      },
      {
        "virtualPath": "System.Security.Cryptography.X509Certificates.dll",
        "name": "System.Security.Cryptography.X509Certificates.owm5w27pqj.dll",
        "integrity": "sha256-OBvRl7+pEBQxBjIT114GmQvpBExlmBlStKYOrscPBHQ="
      },
      {
        "virtualPath": "System.Security.Cryptography.dll",
        "name": "System.Security.Cryptography.ho6icksv18.dll",
        "integrity": "sha256-Uc7VPAVzN1UHtr9zKOQ9SBhyULjnGBfMNoDM1OO2JEo="
      },
      {
        "virtualPath": "System.Security.Principal.Windows.dll",
        "name": "System.Security.Principal.Windows.vfosdg4fzj.dll",
        "integrity": "sha256-RShDNUPydZul6q+sUIa1U6194XfON6LDybk/RG54+1U="
      },
      {
        "virtualPath": "System.Security.Principal.dll",
        "name": "System.Security.Principal.p7fo3enwye.dll",
        "integrity": "sha256-Ba4PezXu6g5gMsDD71iMEZ2dJTkWpBGog/Nl8x79dcY="
      },
      {
        "virtualPath": "System.Security.SecureString.dll",
        "name": "System.Security.SecureString.jqloeb61ot.dll",
        "integrity": "sha256-C/6x7vZTTmYbST6N4vIO6DFKWel99A0gzzUHWZhu9oY="
      },
      {
        "virtualPath": "System.Security.dll",
        "name": "System.Security.3n7uv9b0dx.dll",
        "integrity": "sha256-0YopLYVQoKnuXH/2LWfSaApm8ZN37TUmZx7HaBjQIII="
      },
      {
        "virtualPath": "System.ServiceModel.Web.dll",
        "name": "System.ServiceModel.Web.n1p2xbw8mf.dll",
        "integrity": "sha256-S7hqB3S3QeoWR6ea/6bjJs8qVzUjSjuTYhF7mZ13P3U="
      },
      {
        "virtualPath": "System.ServiceProcess.dll",
        "name": "System.ServiceProcess.h7nzvjhsq0.dll",
        "integrity": "sha256-w+RI5zygS163os7gyMe/Ig+BHhyWOrlI/ruzskwfdMQ="
      },
      {
        "virtualPath": "System.Text.Encoding.CodePages.dll",
        "name": "System.Text.Encoding.CodePages.curumpab23.dll",
        "integrity": "sha256-jN1KcdAzanrQQyAdhcA1bjVIOrlSfkIwB+8ZwIZ5moo="
      },
      {
        "virtualPath": "System.Text.Encoding.Extensions.dll",
        "name": "System.Text.Encoding.Extensions.2d5qkiqhgc.dll",
        "integrity": "sha256-pplcIZrhcjUF/fOK6GZQYcjGzFFV2i/5MxzGxYYTk4I="
      },
      {
        "virtualPath": "System.Text.Encoding.dll",
        "name": "System.Text.Encoding.lk2cj53a14.dll",
        "integrity": "sha256-+5B+RXUOkhfLcfzmQRuxYYljdLuozbVR6CdnbrXqha8="
      },
      {
        "virtualPath": "System.Text.Encodings.Web.dll",
        "name": "System.Text.Encodings.Web.d3bze9980m.dll",
        "integrity": "sha256-6UTx/ewSLfMXmxF9+GEzo8f7BSjMZJYcZ5yQdJOzJ1U="
      },
      {
        "virtualPath": "System.Text.Json.dll",
        "name": "System.Text.Json.bo0bcvs936.dll",
        "integrity": "sha256-1b85BcHHdHG1uWy0vEhj2bF0Xm2/RXzE6y25Sc3cdHc="
      },
      {
        "virtualPath": "System.Text.RegularExpressions.dll",
        "name": "System.Text.RegularExpressions.jpeymgacxs.dll",
        "integrity": "sha256-Cctmg2OqvlOoJb5TjbS6eGW9+eHrHzsjlS5SB2fxjSw="
      },
      {
        "virtualPath": "System.Threading.AccessControl.dll",
        "name": "System.Threading.AccessControl.mvbw9c1yhs.dll",
        "integrity": "sha256-3hJezlrWK0KFnV1yAVZhoKTt0MCNMbD/24jQdfXB+7k="
      },
      {
        "virtualPath": "System.Threading.Channels.dll",
        "name": "System.Threading.Channels.a48fi7z6ef.dll",
        "integrity": "sha256-2lSBD+iZrb0shrmkaSXniqaxtekYP2okpsV3zbGObU8="
      },
      {
        "virtualPath": "System.Threading.Overlapped.dll",
        "name": "System.Threading.Overlapped.si7gr6sxap.dll",
        "integrity": "sha256-7KJ2DxCxKMmR95JoXZTCEd6+Bmz7aM+tI2ReoUv85x0="
      },
      {
        "virtualPath": "System.Threading.Tasks.Dataflow.dll",
        "name": "System.Threading.Tasks.Dataflow.2l5bbgyxw4.dll",
        "integrity": "sha256-BnwSogVbsLRfoOY4lKfj/2hWjCyvOVkQKBGs3g5YPYs="
      },
      {
        "virtualPath": "System.Threading.Tasks.Extensions.dll",
        "name": "System.Threading.Tasks.Extensions.0dobqr3ixg.dll",
        "integrity": "sha256-FKZwfEBdWA5mAunbCGW289UR+cnkdJEkXGIuEPbOLAQ="
      },
      {
        "virtualPath": "System.Threading.Tasks.Parallel.dll",
        "name": "System.Threading.Tasks.Parallel.k2zd0swf48.dll",
        "integrity": "sha256-NF3gQ0fr1urqpIRZJxnjHV5zOA2qKuyWiAy9YC0KquU="
      },
      {
        "virtualPath": "System.Threading.Tasks.dll",
        "name": "System.Threading.Tasks.zzcamida1c.dll",
        "integrity": "sha256-Tw6unnazx3sm46e0YQCaPuQ0P7RrprtZeGxUUerlzqk="
      },
      {
        "virtualPath": "System.Threading.Thread.dll",
        "name": "System.Threading.Thread.xemlx11tk3.dll",
        "integrity": "sha256-R+a7b9cJTlbKzzixBwU+ntaFuP5Au08tv21Ws4qZcWw="
      },
      {
        "virtualPath": "System.Threading.ThreadPool.dll",
        "name": "System.Threading.ThreadPool.xduwgke46b.dll",
        "integrity": "sha256-1SEk2KH4jYEp+IRyyczCab9n/+UaQ46PS3cRrdc1sCM="
      },
      {
        "virtualPath": "System.Threading.Timer.dll",
        "name": "System.Threading.Timer.09qk8ue68p.dll",
        "integrity": "sha256-HJ4wPc3h8ubW5qblpqFZ7s+oZo3oErRmmQ3eXfPyCmg="
      },
      {
        "virtualPath": "System.Threading.dll",
        "name": "System.Threading.h8yvbtmmbx.dll",
        "integrity": "sha256-7+G2qMHJI8mCwnX9IVuMQPyX9TSccJSVaLDBIKGPuv4="
      },
      {
        "virtualPath": "System.Transactions.Local.dll",
        "name": "System.Transactions.Local.q8eoxdt7tc.dll",
        "integrity": "sha256-GgOPtM71h0B6497IL5BxOzP7yZ7SXy0F+PkxzWCAmpg="
      },
      {
        "virtualPath": "System.Transactions.dll",
        "name": "System.Transactions.4oloqqwqez.dll",
        "integrity": "sha256-tAWfShA6AHhAuAiuCOWR0kqntkhYU8qkZDU0IX6fZAE="
      },
      {
        "virtualPath": "System.ValueTuple.dll",
        "name": "System.ValueTuple.ix6h1nvrvf.dll",
        "integrity": "sha256-Vko5UqRTVhdEksTpng6XlbrZaEAmQWiTSJwjiod+G74="
      },
      {
        "virtualPath": "System.Web.HttpUtility.dll",
        "name": "System.Web.HttpUtility.1z5g50oq0b.dll",
        "integrity": "sha256-w1j8u+dkLOWKMd2zW4HNlIqQho9Gp8u429FMoBcuBhA="
      },
      {
        "virtualPath": "System.Web.dll",
        "name": "System.Web.wj09sfnpp6.dll",
        "integrity": "sha256-DFOzDiNV3wlMCyGGP80nHiCzcoFnVGcdoI/OyecBgpw="
      },
      {
        "virtualPath": "System.Windows.dll",
        "name": "System.Windows.83m22ekc4k.dll",
        "integrity": "sha256-VFZ2ofireBg0ydC3TIQ1aZzwsa3EDaZzDmOk17TrfvM="
      },
      {
        "virtualPath": "System.Xml.Linq.dll",
        "name": "System.Xml.Linq.yp1o29idd2.dll",
        "integrity": "sha256-toQhpt4VmaF0w8hfeaBqGA6NlqOhNXOxRULAiQutXsk="
      },
      {
        "virtualPath": "System.Xml.ReaderWriter.dll",
        "name": "System.Xml.ReaderWriter.mrtyrc7t4s.dll",
        "integrity": "sha256-ztloCUrsLqO7xBVEQc98gFxnm35FdMudzymeAYShR9k="
      },
      {
        "virtualPath": "System.Xml.Serialization.dll",
        "name": "System.Xml.Serialization.2wp16nirhw.dll",
        "integrity": "sha256-rmTPXcC6rdrnXnX/3iPUkk2PDbL1ejOsIjp+Eaa6+i8="
      },
      {
        "virtualPath": "System.Xml.XDocument.dll",
        "name": "System.Xml.XDocument.7pp9r08htu.dll",
        "integrity": "sha256-pVqF3l262EPuLp0LhVgOhuTq5mgF5e558RwzvnHtHTI="
      },
      {
        "virtualPath": "System.Xml.XPath.XDocument.dll",
        "name": "System.Xml.XPath.XDocument.fmsl56v2sb.dll",
        "integrity": "sha256-2Q5ZGsTWz9SGnPa9k0ptdz/gfAfWXWDQgNn8HurJZtA="
      },
      {
        "virtualPath": "System.Xml.XPath.dll",
        "name": "System.Xml.XPath.khfi1pwwge.dll",
        "integrity": "sha256-6MNiGFn/Mhl4MD1J1uUigHpC+wzUcpRjd7a8GTexTdU="
      },
      {
        "virtualPath": "System.Xml.XmlDocument.dll",
        "name": "System.Xml.XmlDocument.bx7pfu65pn.dll",
        "integrity": "sha256-ocQXSWRXOAy8+rz84wJ1MMYwecGOSXKEAzRcVAXxCN4="
      },
      {
        "virtualPath": "System.Xml.XmlSerializer.dll",
        "name": "System.Xml.XmlSerializer.96e40c60v6.dll",
        "integrity": "sha256-wTBU31gNJL1EYeNfZNKG0Anu1H+h1X74CBFkw5Ufhto="
      },
      {
        "virtualPath": "System.Xml.dll",
        "name": "System.Xml.lcez5tkr21.dll",
        "integrity": "sha256-mxPuvlpfcoeB/iAKjKNTkZ51CHbAgJ+RIXU2isKdT6U="
      },
      {
        "virtualPath": "System.dll",
        "name": "System.r2zetkh1bc.dll",
        "integrity": "sha256-EwaAbdwQ8d4y00287cEu8zHkzLWEUwxme/TglQZ1vUQ="
      },
      {
        "virtualPath": "WindowsBase.dll",
        "name": "WindowsBase.8htwaz9fny.dll",
        "integrity": "sha256-PGN4ZamsVtNPZoKvlx1N3hl2aQuJrhCg8kspcJZ7AkY="
      },
      {
        "virtualPath": "mscorlib.dll",
        "name": "mscorlib.3tck6tnlnq.dll",
        "integrity": "sha256-14fRZBafCTh8P3UqpZW5dJ+SOD56cuucZ55xCLM3WAQ="
      },
      {
        "virtualPath": "netstandard.dll",
        "name": "netstandard.2bbrofd6xa.dll",
        "integrity": "sha256-/nV8+Ns90kNwzHZeMIaz0KY8765f2rpDHdADfq1WBag="
      },
      {
        "virtualPath": "System.Reactive.dll",
        "name": "System.Reactive.3xw9572539.dll",
        "integrity": "sha256-GfARLNH1Fy7iaI6W3dRK2jmkuxyyMVoVS2PpBk9uPcA="
      },
      {
        "virtualPath": "Ellabit.dll",
        "name": "Ellabit.lgw97pndrj.dll",
        "integrity": "sha256-a9iQp0P1au2DcClOiGevbs+gWBMRx5NM7vdIHjH6YR4="
      }
    ],
    "satelliteResources": {
      "cs": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.zpxcc88af1.dll",
          "integrity": "sha256-SR6Ek7yTOMHUhDKS5TROl1w94HgNUeFJfwwdPx1oHX8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.9q7a2k6tyg.dll",
          "integrity": "sha256-offouksuJ48aMAuGeCbTcHz/o7PCfpWBYeE84Zq1PKs="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.clihd3fqt1.dll",
          "integrity": "sha256-YAG/oDaw+/otPnSuYtiD94zx6/i6UTPfyCKw3yWysdw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.rewcz6is5w.dll",
          "integrity": "sha256-EyrN3RxIRJQ9d9QieV+l4rxWWsIJhGVhplrvFWjGMeg="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.ps2fmwffhc.dll",
          "integrity": "sha256-6cHL3skdgWJkFM2+n4JQK/jx1wpLDbjLzJKckPLcizY="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.12dsvmw17u.dll",
          "integrity": "sha256-GQgoLa5HdF07uFUgjekcljAKnup670ndxeC4GparPOw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.cpjq4vqds0.dll",
          "integrity": "sha256-wNn/7+LQf1GR+/Cg53PsmTTS9ORcgpmq8LKb5UAo1RY="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.ewrrp2eibm.dll",
          "integrity": "sha256-/iaQTzP8/yVrLI+yHUKBpgYeVKBTtHvzpXRJqyrYd1E="
        }
      ],
      "de": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.o1u5guvjnv.dll",
          "integrity": "sha256-pOA98pmRr/XF2MRuZ+/PELEQbyOZvTh0mV+6iC4qaA0="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.tcjwng5kpn.dll",
          "integrity": "sha256-/TAc2UH43oI8ZBoHbxrWIEQREnCCrCcjdIiw7bBNU3E="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.21a9ukmlaa.dll",
          "integrity": "sha256-BukEdwC1l/8uVFmAe5K0/j/Uyi0978ny0Krt4M8UtSk="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.domo8c98hj.dll",
          "integrity": "sha256-My8LNK2tMl362SHcrcMzCKzmVl67chGUeec7A8BNdwY="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.mimgxgtxhp.dll",
          "integrity": "sha256-/uajweyFRStFo0PSlVq/rvq1ixkIcLpM6Qd82yw/tow="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.1zspe13imj.dll",
          "integrity": "sha256-7YCzwY0nyGt8E/dbOeTYK9di+3kcYlLWnB+Qr4X/HY8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.ed6ykp5f5e.dll",
          "integrity": "sha256-wvyQ4Mo50XYMoorRqVKSEgmrfYmJKs8cB54Q1ZxjYck="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.tpw94kh8n7.dll",
          "integrity": "sha256-H46YvHON8uDG+AP24wGC7GwCh9XvzvTUjuhqKEM0ZME="
        }
      ],
      "es": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.0uw95fcfes.dll",
          "integrity": "sha256-eE8vF6gJi5kM+RaDgKH2jl6NHDpV6mr63c5Qj0l61FQ="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.bnwxjtkw6e.dll",
          "integrity": "sha256-h+oG957LhuAdatuN4+klE2KGoiLBlqoeCdiyb5u/8Gg="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.vu2ertuyjh.dll",
          "integrity": "sha256-CQsefoazQb+Art+5qMi5k+PidlkJZHFl11XlpcJtp8c="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.n525hb3rh9.dll",
          "integrity": "sha256-K0e//W1iujlo7IOAhezVQYjiVH73glOHlUzkfDtKlEI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.1o8k0mdyd1.dll",
          "integrity": "sha256-Hy9+5NM4vt/ip9egk8z8QD6/y/BsFowM9toThEkL8UA="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.m6vm75el3j.dll",
          "integrity": "sha256-XgKmE8V8yPA2PU3dzqmnqNFDPVKhHW5wlYDsOGUvQ3U="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.lxyuoj0h76.dll",
          "integrity": "sha256-WZD48BbqHqByH4xxcT0FDE42b7ZGzjIlwEN/KF5PPTo="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.eblz5i5tk6.dll",
          "integrity": "sha256-VmwiSGoNyATbpELpWR6GMoBhY4igSh/w3gwhB71Lvcs="
        }
      ],
      "fr": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.t5du820f3z.dll",
          "integrity": "sha256-Ia68a1EkpMEomSuE/iZjWTH0AyNWG8nT7/Tyrpx97Zc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.ki9x3fdqku.dll",
          "integrity": "sha256-bH2mUbWyDh5bORj0DkTCrNqW23sRvllTzf5eVFtx9HA="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.q3p5v50rf2.dll",
          "integrity": "sha256-VoHbxC/bZGwC7DuzALEOhontfm7+Y2S79lY975wrulA="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.kh2a5qziu7.dll",
          "integrity": "sha256-GKhVtTnunasKkMXbGJ7kkl3yIg8bfoi+FAR9qe54hlw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.kgurxotn2h.dll",
          "integrity": "sha256-DHxs/S68FemjN57sFnRsIdG7Rz0gAnimKfN+8xUkBLc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.gf06nessfh.dll",
          "integrity": "sha256-rHaeiMSu+0JTToSajAw6G1AIfIwGzmEVntjtmDnIemc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.y6bdag393f.dll",
          "integrity": "sha256-FoxPcCh5qIml+3z0V1VHhtzXw6XhOQkdoLXJrzLGEcM="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.6tsrv0q02w.dll",
          "integrity": "sha256-mun30XkcvRQ+QtS+X7dBvpQkosRHl3ILzsix8uK5YKQ="
        }
      ],
      "it": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.2v1tmr55vp.dll",
          "integrity": "sha256-rmCdp9Lc0D8Aid4b+nG2FRXu+rw2DqN1S7Io38p8UC8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.jcssg07kye.dll",
          "integrity": "sha256-fQHRdGMaMM2Jnk5kBAHtMZ9UKtjfJGQewkB6cukQaac="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.95zafyqghj.dll",
          "integrity": "sha256-bafqa5GqLnQrqKAxoe2yrfzUQ+jIu1rXv66M/Mrq/ww="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.ligawvmeqd.dll",
          "integrity": "sha256-47FZVjYkZ9+/VzQTgRhRhRGLuaOti+Wm2wXk43DOF8M="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.f6za8sfnox.dll",
          "integrity": "sha256-l3hUEnUA0sUV3a4eFEN4BqoMgIsFuy31iTve8RbyV2U="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.jr8stwxta5.dll",
          "integrity": "sha256-odejT/VIWpbE8BPiWvO4Iukb9mFE45rS6ik72Cov3z4="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.wxebgneojg.dll",
          "integrity": "sha256-ZMzSrwnSxsYhxATh5/Qukgm5v+AWOFRvgLDGba8r85g="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.ft8jlu5qco.dll",
          "integrity": "sha256-nQ+vpQd5By7xN2WvEtsF08809S3u6/Zdtt8yDk/okxQ="
        }
      ],
      "ja": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.pnufb3rvoc.dll",
          "integrity": "sha256-C3Dy5g7rFr7ntqx8qUojegWfaYePtyITSb4F+2thZns="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.xloyk3953o.dll",
          "integrity": "sha256-FQF7tpopNPIV1C4nv3NnBsexHd33PXSUHKY8tcrwkqE="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.8jeomxo4i5.dll",
          "integrity": "sha256-lNk8jgxvwwVR5sZgISoPFA5ljTgkrKYytqPdv6y/6DA="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.gvhrfl5smd.dll",
          "integrity": "sha256-xDnYIfl7CzLiIn7FYHj3soQe+4IdH6JPJGJ0mlb1Xqo="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wgzuxooe1p.dll",
          "integrity": "sha256-EDBp+mJNZBhktKejkLDOEWHttCnxGRswGqXUkQrA8Sw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.t5703r7w8j.dll",
          "integrity": "sha256-QcPx5m0ACeMArPbeJtrRY53psg1RyOWzNO+gBUMykO8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.9c6sy6k6nv.dll",
          "integrity": "sha256-GQlhltJmnl4fudcF+DCCelAbrlLTQWu/KlOn1Zka9wo="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.zc7sqlw8pa.dll",
          "integrity": "sha256-Q+KS72zvWoA691wJmKRp1m3v2weqsLKA48o65uXA7MM="
        }
      ],
      "ko": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.h7i2pzpxwl.dll",
          "integrity": "sha256-rb359WHpW1QSKcBI/96ThVgSGiAq45mSVQZdAzWobxU="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.8fvlonm6ru.dll",
          "integrity": "sha256-rLmQhweEmXSSgWYIYS8NuTtCVGhwLskcYLRVrqqM1hM="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.cy93l84emw.dll",
          "integrity": "sha256-JGrbDlyCs39+niDS4LP5Y5DoGMP13BNT/VIlHidxhRI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.pe9ozl5t5h.dll",
          "integrity": "sha256-oUyTK/bmz/5EBSWQs206NEorWST15aibT1m9tI2aXVw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.ty8qir0pkg.dll",
          "integrity": "sha256-5Y13/BSTBEJT1XivbHB50Oxai1XKvfXhlH1SWl61r2w="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.bh6l95uyuv.dll",
          "integrity": "sha256-D1EtgUNfGXFuJptZTRmTRdQt+LJIvQRbkEWbnbvvlxQ="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.rk2v8a5hya.dll",
          "integrity": "sha256-yx4lVZ3QHXh2jfN4LA0V5/HJzgDAzC9BtOUf6JfGlzE="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.p64h5vt9wb.dll",
          "integrity": "sha256-cUAHcvXiBGZZxxXgjxjKi8FCLjXZLe3629WNBHdOB/w="
        }
      ],
      "pl": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.656odw710t.dll",
          "integrity": "sha256-5m3RxO0ankLnwPNqxuKSRKsEaJZVJbGdDi0btlzOgmA="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.xdd0opqsoz.dll",
          "integrity": "sha256-xf+LfPbdKxN5Us9FCqJaGf3/EgEfWsjeU04GyR6e7z0="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.vcu7n39982.dll",
          "integrity": "sha256-kTd1m3G0HY2Rz3Gvjs9on1Z2yRZeIqQ10+oyw6eloA4="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.ah751xrimi.dll",
          "integrity": "sha256-4lVOQlvponiUOMJru1vkh0MkEjcRXoabZxHDqu1HOl8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.6iomtnkgyl.dll",
          "integrity": "sha256-jl5z1QQGhbkLY4SV0N09rx9FqNxjNd5wOXKesfioXbk="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.b3h09gs2i2.dll",
          "integrity": "sha256-eYAiWoL3j+3heIbq947PCeCHzO/WWogUa14AF07twM0="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.wru8ozvjpx.dll",
          "integrity": "sha256-zIHAM/qGQZsNmV52ChG7t3qIoH1pEE5r9DXXQIaO26E="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.cmzjsclj3f.dll",
          "integrity": "sha256-FJdFx4td9iM1db70AiYo0Br2rGPeheEDfEU9pADv4cw="
        }
      ],
      "pt-BR": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.8ij9og6fhk.dll",
          "integrity": "sha256-AEOZUMfbKXck66DmiMJG325EBQI/dH/GZigfvVSSy+c="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.qkryz6kpk3.dll",
          "integrity": "sha256-5uRkmd3w8r2+DUDnci0uw9kYs8ds+P/1beFP+pNZk50="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.50dy65ps1r.dll",
          "integrity": "sha256-VQC8CH5IAD5hd0+ulCCoBwm382GpbSYhRSW6hpzAONM="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.1fi30bhc7j.dll",
          "integrity": "sha256-A2SqoBvCQODwYHqGAMOfgVlwBT1G0imMqs6mq/ScwJU="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.ana3gnlg6f.dll",
          "integrity": "sha256-Wou8zrFZRbGwTH86QKmCJng0/ulGT+pu9VAyzt8xkBo="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.h9o1ptns4v.dll",
          "integrity": "sha256-Fe7frr+LOEEOVwS5N4XGvUbjaMNmbKoptoItNc5zFr0="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.35puwfk4ft.dll",
          "integrity": "sha256-x9YSwkSgXDM/awGD66Fe+DGQOjzcUWg1xaQEj5JOxk8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.m6uxpn6cof.dll",
          "integrity": "sha256-8hPpc7d5A67FL13JANku6z3jRs90kxo/15f2E45VhpE="
        }
      ],
      "ru": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.lpq4ajl69l.dll",
          "integrity": "sha256-OabMg7zNf1xREwrgVgbf2FDu1LIv3Tgop0VfaWM/AKE="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.xs24wpwc1v.dll",
          "integrity": "sha256-z/TE6hd+BpnDlGKwSZ7AhSnoSAHNNeYn9/f2BViJJlk="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.qi8lxgcwkh.dll",
          "integrity": "sha256-niAEtG0vR3f1J7fqTolPyR+plC0c983hODUox+FwJ3c="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.fo5eherdqy.dll",
          "integrity": "sha256-P600UNWQpyxFZ/XWE16dNCPkETeHvQju0zsB+9lUMsc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.vy0c6dielq.dll",
          "integrity": "sha256-50kgFoYcJ91n7G4+EdGhmfVRuP4c/CAEmBmCopCzbos="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.2p6gkby0tl.dll",
          "integrity": "sha256-GrpNIUstwmfTKXG9wDZ1/ekqHTNMvq5uT+g8CPIBsoI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.wf08q8uzl3.dll",
          "integrity": "sha256-PM48pDfC6JQvhDayydQQekPwT1ppSsEQeky1CdkQAiI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.b2wbrlozhm.dll",
          "integrity": "sha256-7dmOSW4Gzh2PbnQter6aiBQcAJafU8HG7TfaQtUH420="
        }
      ],
      "tr": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.onhyjck2lb.dll",
          "integrity": "sha256-5PDp5Ko6drlnnhqs1AUQjob1Rof2os+Hsu+XZr8LGwI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.vogo3zh3l1.dll",
          "integrity": "sha256-gXa5UXE+XvDooBLdJ9NEqeB23GtL/kPQtjYiBbyJeU8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.3w9nh9ie5i.dll",
          "integrity": "sha256-06bHzZMM8VIP4lqVak+ytt06LFf6unni+IcUK0lqmdc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.bk50qfmjoc.dll",
          "integrity": "sha256-KzIMy6WGlc0oP/og9fbiVwfR+f5V8D+HjXe+zNck2cw="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.xdfbsfhky1.dll",
          "integrity": "sha256-W5X3aZcZbL+DcsKQOTP9v6hnEOtxtZNTRVs1g77cUQ8="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.m50di7q68h.dll",
          "integrity": "sha256-9s9FIA/mxpP7jIyjfoozeXTPnuL4Pf4zA17FMGbkuKc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.zmjg9v4oal.dll",
          "integrity": "sha256-a4wsBeSDdtMXt4VTfwJg4OQX6vrGqMHI4nEoNTDjJBs="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.hv4cio8bgn.dll",
          "integrity": "sha256-U2oJiSxRdXnb/FUyveMCF4qqEartvaqFQdKxbobPdX8="
        }
      ],
      "zh-Hans": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.ko5srjatd6.dll",
          "integrity": "sha256-PO0kgV0vXo7KHbQ5fvHw2jkBNI1WDD/NSaoldZ4V6l0="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.i2cs4dfba9.dll",
          "integrity": "sha256-GrThXil+Ood+QBqEomh3r4s+b3R24TW4K4qpXL1eS8c="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.oxzt52my44.dll",
          "integrity": "sha256-LKiebGvKpmV99Mq4o9FShnVHu2uuPHpKsZLVan0brMk="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.slw270wi4j.dll",
          "integrity": "sha256-kPiXk2S+fHoy9belVT4U77AfMQsGO/xyAwHDm03qWN4="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.2oqwboo9em.dll",
          "integrity": "sha256-AlqgX+bHRCA1Die+OEv8UurASoSJNygKuxG6M3/btkg="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.0whr52kzop.dll",
          "integrity": "sha256-sP96guVv3X+aB0iwuHNOJxWG9IaNmPAneO9/X+42jJM="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.waf5hmddfn.dll",
          "integrity": "sha256-SEo2YVwnFaqsoZCmzGJ6+Y/1qK3V4TXfegeGRz3SDT4="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.n4juu9rwmb.dll",
          "integrity": "sha256-Vw7XCNoOUYUPfyulAzcsg3r4Vmwes7l+ICcErPp+mC8="
        }
      ],
      "zh-Hant": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.dll",
          "name": "Microsoft.CodeAnalysis.resources.5hx9d18kxu.dll",
          "integrity": "sha256-uWLNxmqE6PRaryS4A2S+h9fMIbgz/XHTKCiOWSa+ckc="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.g77gd0dqxr.dll",
          "integrity": "sha256-fAUM2OALi4wz+bPOvzkwoS0VREz9okgsAAqQCTLzcgs="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.joajd3kh36.dll",
          "integrity": "sha256-01UFBY0GRkVF3l1UkxCbwgd4jNDFAt3r6cea7nq8ob4="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Scripting.resources.o2s7ilgr7b.dll",
          "integrity": "sha256-4A9HizrsGWMDw5vBenOXU5OrORUaYIa3L9T3eFk6m/o="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.po9657zuiu.dll",
          "integrity": "sha256-dzgc6AOOblP9ZK9NkX9ek4RY4LO8BHj+Z0gKTLZjZ4g="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.dll",
          "name": "Microsoft.CodeAnalysis.Features.resources.qd0vvlwdmp.dll",
          "integrity": "sha256-UrnabtRCO8KsISXMqxLZgPaolc254XPYdlNuZqHCqfI="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.dll",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.hwbzk8aqrp.dll",
          "integrity": "sha256-/wQZ9Dyjq2SxgafWdnMq/ZHwRRDLcatdz3pfvGbwQbs="
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.dll",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.51av0zna24.dll",
          "integrity": "sha256-iaA1Sd02z1tZ+Ljsz1N6VR+F6zCZm8Gh5NQNDYsGV7Y="
        }
      ]
    }
  },
  "debugLevel": 0,
  "globalizationMode": "sharded",
  "extensions": {
    "blazor": {}
  },
  "runtimeConfig": {
    "runtimeOptions": {
      "configProperties": {
        "Microsoft.AspNetCore.Components.Routing.RegexConstraintSupport": false,
        "System.Diagnostics.Debugger.IsSupported": false,
        "System.Diagnostics.Metrics.Meter.IsSupported": false,
        "System.Diagnostics.Tracing.EventSource.IsSupported": false,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": false,
        "System.Net.Http.WasmEnableStreamingResponse": true,
        "System.Net.SocketsHttpHandler.Http3Support": false,
        "System.Reflection.Metadata.MetadataUpdater.IsSupported": false,
        "System.Resources.UseSystemResourceKeys": true,
        "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false,
        "System.Text.Encoding.EnableUnsafeUTF7Encoding": false,
        "System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault": true
      }
    }
  }
}/*json-end*/);export{gt as default,ft as dotnet,mt as exit};
