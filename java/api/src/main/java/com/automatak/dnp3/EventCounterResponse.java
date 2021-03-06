/**
 * Copyright 2013 Automatak, LLC
 *
 * Licensed to Automatak, LLC (www.automatak.com) under one or more
 * contributor license agreements. See the NOTICE file distributed with this
 * work for additional information regarding copyright ownership. Automatak, LLC
 * licenses this file to you under the Apache License Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0.html
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */
package com.automatak.dnp3;

/**
 * Enumeration for Group/Variation pairs used for counter events
 */
public enum EventCounterResponse {

    GROUP22_VAR1(0),
    GROUP22_VAR2(1),
    GROUP22_VAR5(2),
    GROUP22_VAR6(3);

    public int getId() {
        return id;
    }

    private final int id;

    private EventCounterResponse(int id)
    {
        this.id = id;
    }
}
