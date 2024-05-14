import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EarthApiService {

  constructor(private http: HttpClient) { }

  getIntro(): Observable<string> {
    return this.http.get(`${environment.earthApiUrl}api/intro`, environment.textOptions);
  }

  getFact(): Observable<string> {
    return this.http.get(`${environment.earthApiUrl}api/fact`, environment.textOptions);
  }
}
