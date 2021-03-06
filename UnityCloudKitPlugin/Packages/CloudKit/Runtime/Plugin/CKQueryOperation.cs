//
//  CKQueryOperation.cs
//
//  Created by Jonathan Culp <jonathanculp@gmail.com> on 03/26/2020
//  Copyright © 2020 HovelHouseApps. All rights reserved.
//  Unauthorized copying of this file, via any medium is strictly prohibited
//  Proprietary and confidential
//

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

namespace HovelHouse.CloudKit
{
    /// <summary>
    /// A database operation used to lookup record ids using the provided query
    /// </summary>
    public class CKQueryOperation : CKObject, IDisposable
    {
        #region dll

        // Class Methods
        

        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_init(
            out IntPtr exceptionPtr
            );
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_initWithQuery(
            IntPtr query, 
            out IntPtr exceptionPtr
            );
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_initWithCursor(
            IntPtr cursor, 
            out IntPtr exceptionPtr
            );
        

        

        

        // Properties
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_GetPropQuery(HandleRef ptr);
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_SetPropQuery(HandleRef ptr, IntPtr query, out IntPtr exceptionPtr);
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_GetPropCursor(HandleRef ptr);
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_SetPropCursor(HandleRef ptr, IntPtr cursor, out IntPtr exceptionPtr);
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern IntPtr CKQueryOperation_GetPropZoneID(HandleRef ptr);
        
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_SetPropZoneID(HandleRef ptr, IntPtr zoneID, out IntPtr exceptionPtr);
        // TODO: DLLPROPERTYSTRINGARRAY
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_SetPropRecordFetchedHandler(HandleRef ptr, RecordFetchedDelegate recordFetchedHandler, out IntPtr exceptionPtr);
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_SetPropQueryCompletionHandler(HandleRef ptr, QueryCompletionDelegate queryCompletionHandler, out IntPtr exceptionPtr);
        

        #endregion

        internal CKQueryOperation(IntPtr ptr) : base(ptr) {}
        
        
        
        
        public CKQueryOperation(
            )
        {
            
            IntPtr ptr = CKQueryOperation_init(
                out IntPtr exceptionPtr);

            if(exceptionPtr != IntPtr.Zero)
            {
                var nativeException = new NSException(exceptionPtr);
                throw new CloudKitException(nativeException, nativeException.Reason);
            }

            Handle = new HandleRef(this,ptr);
        }
        
        
        public CKQueryOperation(
            CKQuery query
            )
        {
            if(query == null)
                throw new ArgumentNullException(nameof(query));
            
            IntPtr ptr = CKQueryOperation_initWithQuery(
                query != null ? HandleRef.ToIntPtr(query.Handle) : IntPtr.Zero, 
                out IntPtr exceptionPtr);

            if(exceptionPtr != IntPtr.Zero)
            {
                var nativeException = new NSException(exceptionPtr);
                throw new CloudKitException(nativeException, nativeException.Reason);
            }

            Handle = new HandleRef(this,ptr);
        }
        
        
        public CKQueryOperation(
            CKQueryCursor cursor
            )
        {
            if(cursor == null)
                throw new ArgumentNullException(nameof(cursor));
            
            IntPtr ptr = CKQueryOperation_initWithCursor(
                cursor != null ? HandleRef.ToIntPtr(cursor.Handle) : IntPtr.Zero, 
                out IntPtr exceptionPtr);

            if(exceptionPtr != IntPtr.Zero)
            {
                var nativeException = new NSException(exceptionPtr);
                throw new CloudKitException(nativeException, nativeException.Reason);
            }

            Handle = new HandleRef(this,ptr);
        }
        
        


        
        
        
        /// <value>Query</value>
        public CKQuery Query
        {
            get 
            { 
                IntPtr query = CKQueryOperation_GetPropQuery(Handle);
                return query == IntPtr.Zero ? null : new CKQuery(query);
            }
            set
            {
                CKQueryOperation_SetPropQuery(Handle, value != null ? HandleRef.ToIntPtr(value.Handle) : IntPtr.Zero, out IntPtr exceptionPtr);
            }
        }

        
        /// <value>Cursor</value>
        public CKQueryCursor Cursor
        {
            get 
            { 
                IntPtr cursor = CKQueryOperation_GetPropCursor(Handle);
                return cursor == IntPtr.Zero ? null : new CKQueryCursor(cursor);
            }
            set
            {
                CKQueryOperation_SetPropCursor(Handle, value != null ? HandleRef.ToIntPtr(value.Handle) : IntPtr.Zero, out IntPtr exceptionPtr);
            }
        }

        
        /// <value>ZoneID</value>
        public CKRecordZoneID ZoneID
        {
            get 
            { 
                IntPtr zoneID = CKQueryOperation_GetPropZoneID(Handle);
                return zoneID == IntPtr.Zero ? null : new CKRecordZoneID(zoneID);
            }
            set
            {
                CKQueryOperation_SetPropZoneID(Handle, value != null ? HandleRef.ToIntPtr(value.Handle) : IntPtr.Zero, out IntPtr exceptionPtr);
            }
        }

        
        // TODO: PROPERTYSTRINGARRAY
        
        /// <value>RecordFetchedHandler</value>
        public Action<CKRecord> RecordFetchedHandler
        {
            get 
            {
                Action<CKRecord> value;
                RecordFetchedHandlerCallbacks.TryGetValue(HandleRef.ToIntPtr(Handle), out value);
                return value;
            }    
            set 
            {
                IntPtr myPtr = HandleRef.ToIntPtr(Handle);
                if(value == null)
                {
                    RecordFetchedHandlerCallbacks.Remove(myPtr);
                }
                else
                {
                    RecordFetchedHandlerCallbacks[myPtr] = value;
                }
                CKQueryOperation_SetPropRecordFetchedHandler(Handle, RecordFetchedHandlerCallback, out IntPtr exceptionPtr);

                if(exceptionPtr != IntPtr.Zero)
                {
                    var nativeException = new NSException(exceptionPtr);
                    throw new CloudKitException(nativeException, nativeException.Reason);
                }
            }
        }

        private static readonly Dictionary<IntPtr,Action<CKRecord>> RecordFetchedHandlerCallbacks = new Dictionary<IntPtr,Action<CKRecord>>();

        [MonoPInvokeCallback(typeof(RecordFetchedDelegate))]
        private static void RecordFetchedHandlerCallback(IntPtr thisPtr, IntPtr _record)
        {
            if(RecordFetchedHandlerCallbacks.TryGetValue(thisPtr, out Action<CKRecord> callback))
            {
                Dispatcher.Instance.EnqueueOnMainThread(() => 
                    callback(
                        _record == IntPtr.Zero ? null : new CKRecord(_record)));
            }
        }

        
        /// <value>QueryCompletionHandler</value>
        public Action<CKQueryCursor,NSError> QueryCompletionHandler
        {
            get 
            {
                Action<CKQueryCursor,NSError> value;
                QueryCompletionHandlerCallbacks.TryGetValue(HandleRef.ToIntPtr(Handle), out value);
                return value;
            }    
            set 
            {
                IntPtr myPtr = HandleRef.ToIntPtr(Handle);
                if(value == null)
                {
                    QueryCompletionHandlerCallbacks.Remove(myPtr);
                }
                else
                {
                    QueryCompletionHandlerCallbacks[myPtr] = value;
                }
                CKQueryOperation_SetPropQueryCompletionHandler(Handle, QueryCompletionHandlerCallback, out IntPtr exceptionPtr);

                if(exceptionPtr != IntPtr.Zero)
                {
                    var nativeException = new NSException(exceptionPtr);
                    throw new CloudKitException(nativeException, nativeException.Reason);
                }
            }
        }

        private static readonly Dictionary<IntPtr,Action<CKQueryCursor,NSError>> QueryCompletionHandlerCallbacks = new Dictionary<IntPtr,Action<CKQueryCursor,NSError>>();

        [MonoPInvokeCallback(typeof(QueryCompletionDelegate))]
        private static void QueryCompletionHandlerCallback(IntPtr thisPtr, IntPtr _cursor, IntPtr _operationError)
        {
            if(QueryCompletionHandlerCallbacks.TryGetValue(thisPtr, out Action<CKQueryCursor,NSError> callback))
            {
                Dispatcher.Instance.EnqueueOnMainThread(() => 
                    callback(
                        _cursor == IntPtr.Zero ? null : new CKQueryCursor(_cursor),
                        _operationError == IntPtr.Zero ? null : new NSError(_operationError)));
            }
        }

        

        

        
        #region IDisposable Support
        #if UNITY_IPHONE || UNITY_TVOS
        [DllImport("__Internal")]
        #else
        [DllImport("HHCloudKit")]
        #endif
        private static extern void CKQueryOperation_Dispose(HandleRef handle);
            
        private bool disposedValue = false; // To detect redundant calls
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                
                //Debug.Log("CKQueryOperation Dispose");
                CKQueryOperation_Dispose(Handle);
                disposedValue = true;
            }
        }

        ~CKQueryOperation()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        
    }
}
