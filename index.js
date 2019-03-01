'use strict';
import { NativeModules } from 'react-native';
const { RNApplicationInfo } = NativeModules;

const RNAppInfo = {
    withLog: RNApplicationInfo.withLog,
    withBundle: RNApplicationInfo.withBundle
}

export default RNAppInfo;