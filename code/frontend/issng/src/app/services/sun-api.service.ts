import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SunApiService {
  constructor(private http: HttpClient) {
  }

  getIntro(): Observable<string> {
    return this.http.get(`${environment.sunApiUrl}api/intro`, environment.textOptions);
  }

  getFact(): Observable<string> {
    return this.http.get(`${environment.sunApiUrl}api/fact`, environment.textOptions);
  }
}
